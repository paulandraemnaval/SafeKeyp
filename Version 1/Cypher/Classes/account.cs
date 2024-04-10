using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.ComponentModel;


namespace Cypher.Classes
{
    [FirestoreData]
    public class Account
    {
        [FirestoreProperty]
        public string Username { get; private set; }
        [FirestoreProperty]
        public string? Password { get; private set; }
        [FirestoreProperty]
        public string? Salt { get; private set; }
        [FirestoreProperty]
        public string? PasswordHash { get; private set; }
        

        public Account(string username, string password)
        {     

           GeneratePasswordHash(password);
           Username = username;
        }

        
        public string exportKey(RSAParameters rsaParams)
        {
            string publicKeyXML; 
            using (StringWriter str = new StringWriter())
            {
                var xmlserialzer = new XmlSerializer(typeof(RSAParameters));
                xmlserialzer.Serialize(str, rsaParams);
                publicKeyXML = str.ToString();
            }
            return publicKeyXML;    
        }
        
        public byte[] convertRSAParametersToBytes(RSAParameters rsaParams)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                new XmlSerializer(typeof(RSAParameters)).Serialize(mem, rsaParams);
                return mem.ToArray();
            }
            
        }

       
        public RSAParameters convertBytesToRSAParameters(byte[] bytes)
        {
            using (MemoryStream mem = new MemoryStream(bytes))
            {
                return (RSAParameters)new XmlSerializer(typeof(RSAParameters)).Deserialize(mem);
            }
        }

        public RSAParameters getRSAParams(string privateKey)
        {
            RSAParameters rsaParams;
            using(StringReader str = new StringReader(privateKey))
            {
                rsaParams = (RSAParameters)new XmlSerializer(typeof(RSAParameters)).Deserialize(str);
            }
            return rsaParams;
        }

        public Account()
        {

        }

        public Account(Account account)
        {
            Username = account.Username;
            Password = account.Password;
            Salt = account.Salt;
            PasswordHash = account.PasswordHash;
        }

        private void GeneratePasswordHash(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[32];
                rng.GetBytes(saltBytes);
                this.Salt = Convert.ToBase64String(saltBytes);
            }   
            using(var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password+Salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                this.PasswordHash = Convert.ToBase64String(hashBytes);
            }
        }


        public bool VerifyPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + Salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string enteredPasswordHash = Convert.ToBase64String(hashBytes);
                return PasswordHash == enteredPasswordHash;
            }
        }

        public void DeriveEncryptionKeys(out byte[] key, out byte[] iv)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.UTF8.GetBytes(Salt), 10000))
            {
                key = deriveBytes.GetBytes(32); // 256-bit key
                iv = deriveBytes.GetBytes(16); // 128-bit IV
            }
        }
        

    }
}
