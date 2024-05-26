using Google.Cloud.Firestore;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna.Classes
{
    [FirestoreData]
    internal class FileRecoveryInformation
    {
        private string secret = "supersecret";

        [FirestoreProperty]
        public string FilePath { get; set; }

        [FirestoreProperty]
        public int QuestionNo { get; private set; }

        [FirestoreProperty]
        public string Answer { get; private set; }


        [FirestoreProperty]
        public string Key { get; private set; }

        [FirestoreProperty]
        public bool isArchived { get; private set; }

        [FirestoreProperty]

        public int PrivateKey { get; private set; }

        public FileRecoveryInformation(string filePath, int QuestionNo, string answer, int PrivateKey, string key)
        {
            this.FilePath = filePath;
            this.QuestionNo = QuestionNo;
            this.Answer = answer;
            this.PrivateKey = PrivateKey;
            this.isArchived = false;
            this.Key = key; // string used to encrypt data;
            ObscureData();
        }
        public FileRecoveryInformation()
        {

        }

        private void ObscureData()
        {
            //data to obscure
            byte[] key = Encoding.UTF8.GetBytes(Key);
            byte[] answer = Encoding.UTF8.GetBytes(Answer);


            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] secrethash = md5.ComputeHash(Encoding.UTF8.GetBytes(secret));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = secrethash, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] encryptedAnswer = transform.TransformFinalBlock(answer, 0, answer.Length);
                    byte[] encryptedKey = transform.TransformFinalBlock(key, 0, key.Length);
                    Answer = Convert.ToBase64String(encryptedAnswer, 0, encryptedAnswer.Length);
                    Key = Convert.ToBase64String(encryptedKey, 0, encryptedKey.Length);
                }
            }
        }

        public string DecryptAnswer()
        {
            byte[] answer = Convert.FromBase64String(Answer);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] secrethash = md5.ComputeHash(Encoding.UTF8.GetBytes(secret));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = secrethash, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] decryptedAnswer = transform.TransformFinalBlock(answer, 0, answer.Length);
                    return Encoding.UTF8.GetString(decryptedAnswer);
                }
            }
        }

        public string DecryptKey()
        {
            byte[] keybytes = Convert.FromBase64String(Key);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] secrethash = md5.ComputeHash(Encoding.UTF8.GetBytes(secret));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = secrethash, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] decryptedAnswer = transform.TransformFinalBlock(keybytes, 0, keybytes.Length);
                    return UTF8Encoding.UTF8.GetString(decryptedAnswer);
                }

            }
        }
    }
}
