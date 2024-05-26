using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Tests
{

    // ------------------------------------------------ ENCRYPTION TESTS ------------------------------------------------ //
    [TestClass]
    public class EncryptionTests
    {

        //ACTUAL TEST METHODS

        [TestMethod]
        
        public void TestEncryptFile1()
        {
            string inputFile = "C:\\Users\\Lenovo\\Desktop\\demo folder\\EVENT DRIVEN OPERATIONS DOCUMENT.docx"; 

            FileInfo fi = new FileInfo(inputFile);
            long fileSize = fi.Length;
            double filesizeGB = fileSize / (1024 * 1024 * 1024);
            
            // Place the test password here
            string testpassword = "placetesthere";
            // Place the test password here



            byte[] key = Encoding.UTF8.GetBytes(testpassword);
            using (SHA256 sha256 = SHA256.Create())
            {
                key = sha256.ComputeHash(key);
            }

            byte[] iv; 
            using (Aes aes = Aes.Create())
            {
                aes.GenerateIV();
                iv = aes.IV;
            }
            try
            {
                EncryptFile(inputFile, key, iv);
            }
            catch(Exception ex)
            {
                Assert.Fail($"Unexpected exception: {inputFile}. Error: {ex.Message}");
            }
            Assert.IsTrue(true, "File is encrypted successfully");

        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestEncryptFile2()
        {
            string inputFile = "C:\\Users\\Lenovo\\Desktop\\demo folder\\22.9GB file.zip";



            // Place the test password here
            string testpassword = "testhere";
            // Place the test password here




            byte[] key = Encoding.UTF8.GetBytes(testpassword);
            using (SHA256 sha256 = SHA256.Create())
            {
                key = sha256.ComputeHash(key);
            }

            byte[] iv;
            using (Aes aes = Aes.Create())
            {
                aes.GenerateIV();
                iv = aes.IV;
            }


            EncryptFile(inputFile, key, iv);
        }


        // ------------------------------------------------ DECRYPTION TESTS ------------------------------------------------ //
       

        [TestClass]
        public class DecryptionTests
        {
            //HELPER METHODS

            public void DecryptFile(string inputFile, string destinationDirectory, byte[] key)
            {
                string outputFile = Path.Combine(destinationDirectory, $"{Path.GetFileNameWithoutExtension(inputFile)}_decrypted");
                byte[] encryptedData = File.ReadAllBytes(inputFile);
                byte[] headerLengthBytes, extensionBytes, iv;
                int headerLength, extensionLength;

                //byte[] length is 4 because Bitconverter.GetBytes returns 4 bytes
                headerLengthBytes = new byte[4];
                Buffer.BlockCopy(encryptedData, 0, headerLengthBytes, 0, headerLengthBytes.Length);
                headerLength = BitConverter.ToInt16(headerLengthBytes, 0);

                //iv is always 16 bytes for AES
                iv = new byte[16];
                Buffer.BlockCopy(encryptedData, headerLengthBytes.Length, iv, 0, iv.Length);
                extensionLength = headerLength - iv.Length;

                //byte[] length varies here because extensions can vary in length
                extensionBytes = new byte[extensionLength];
                Buffer.BlockCopy(encryptedData, headerLengthBytes.Length + iv.Length, extensionBytes, 0, extensionLength);

                string extensionString = Encoding.UTF8.GetString(extensionBytes);

                //entire header length is computed to determine where the encrypted content starts
                int entireHeaderLength = headerLengthBytes.Length + iv.Length + extensionBytes.Length;

                int encryptedContentLength = encryptedData.Length - entireHeaderLength;
                byte[] encryptedContent = new byte[encryptedContentLength];

                Buffer.BlockCopy(encryptedData, entireHeaderLength, encryptedContent, 0, encryptedContentLength);

                //reads encrypted bytes
                using (FileStream fs = new FileStream(outputFile, FileMode.Create))
                {
                    //instantiates decryptor given the extracted IV and entered Key
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = key;
                        aes.IV = iv;

                        //creates aes decryptor
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                        {
                            //copy encrypted data array to a memorystream
                            using (MemoryStream msDecrypt = new MemoryStream(encryptedContent))
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    cryptoStream.CopyTo(fs);
                                }
                            }
                        }
                    }
                }

                //duplicate file name logic
                string newOutputFile = Path.ChangeExtension(outputFile, extensionString);
                string newOutputFileNoEx = $"{Path.GetDirectoryName(newOutputFile)}\\{Path.GetFileNameWithoutExtension(newOutputFile)}";

                int i = 1;
                while (File.Exists(newOutputFile))
                {
                    string concat = $" - ({i})";
                    newOutputFile = $"{newOutputFileNoEx}{concat}";
                    newOutputFile = Path.ChangeExtension(newOutputFile, extensionString);
                    i++;
                }

                //renames the filestream outputfile. doesn't actually move the file
                File.Move(outputFile, newOutputFile);
            }


            //ACTUAL TEST METHODS
            [TestMethod]
            [ExpectedException(typeof(CryptographicException))]
            public void TestDecryptSingleFile1()
            {
                string inputFile = "C:\\Users\\Lenovo\\Desktop\\demo folder\\prac_encrypted";
                string destinationDirectory = "C:\\Users\\Lenovo\\Desktop";

                FileInfo fi = new FileInfo(inputFile);
                long fileSize = fi.Length;
                double filesizeGB = fileSize / (1024 * 1024 * 1024);
                if (filesizeGB >= 2)
                {
                    Assert.IsTrue(true, "File is too big to decrypt");
                    return;
                }

                // Place the test password here
                string testpassword = "";
                // Place the test password here




                byte[] key = Encoding.UTF8.GetBytes(testpassword);
                using (SHA256 sha256 = SHA256.Create())
                {
                    key = sha256.ComputeHash(key);
                }

                byte[] iv;
                using (Aes aes = Aes.Create())
                {
                    aes.GenerateIV();
                    iv = aes.IV;
                }

                DecryptFile(inputFile, destinationDirectory, key);

            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestDecryptSingleFile2()
            {
                string inputFile = "C:\\Users\\Lenovo\\Desktop\\demo folder\\Important code.cpp";
                string destinationDirectory = "C:\\Users\\Lenovo\\Desktop";

                FileInfo fi = new FileInfo(inputFile);
                long fileSize = fi.Length;
                double filesizeGB = fileSize / (1024 * 1024 * 1024);
                if (filesizeGB >= 2)
                {
                    Assert.IsTrue(true, "File is too big to decrypt");
                    return;
                }

                // Place the test password here
                string testpassword = "1234";
                // Place the test password here



                byte[] key = Encoding.UTF8.GetBytes(testpassword);
                using (SHA256 sha256 = SHA256.Create())
                {
                    key = sha256.ComputeHash(key);
                }

                byte[] iv;
                using (Aes aes = Aes.Create())
                {
                    aes.GenerateIV();
                    iv = aes.IV;
                }

                DecryptFile(inputFile, destinationDirectory, key);

            }

            [TestMethod]
            public void TestDecryptSingleFile3()
            {
                string inputFile = "C:\\Users\\Lenovo\\Desktop\\demo folder\\prac_encrypted";
                string destinationDirectory = "C:\\Users\\Lenovo\\Desktop";

                FileInfo fi = new FileInfo(inputFile);
                long fileSize = fi.Length;
                double filesizeGB = fileSize / (1024 * 1024 * 1024);
                if (filesizeGB >= 2)
                {
                    Assert.IsTrue(true, "File is too big to decrypt");
                    return;
                }

                // Place the test password here
                string testpassword = "1234";
                // Place the test password here



                byte[] key = Encoding.UTF8.GetBytes(testpassword);
                using (SHA256 sha256 = SHA256.Create())
                {
                    key = sha256.ComputeHash(key);
                }

                byte[] iv;
                using (Aes aes = Aes.Create())
                {
                    aes.GenerateIV();
                    iv = aes.IV;
                }

                try
                {
                    DecryptFile(inputFile, destinationDirectory, key);
                }
                catch (Exception ex)
                {
                    Assert.Fail($"Unexpected exception: {inputFile}. Error: {ex.Message}");
                }
                Assert.IsTrue(true, "File is decrypted successfully");

            }

        }

        // HELPER FUNCTIONS
        private void EncryptFile(string inputFile, byte[] key, byte[] iv)
        {
            string outputFile = GetOutputFilePath(inputFile);

            byte[] plaintext = File.ReadAllBytes(inputFile);
            byte[] originalFileExtension = Encoding.UTF8.GetBytes(Path.GetExtension(inputFile));

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                byte[] headerLengthBytes = BitConverter.GetBytes(iv.Length + originalFileExtension.Length);
                fs.Write(headerLengthBytes, 0, headerLengthBytes.Length);
                fs.Write(iv, 0, iv.Length);
                fs.Write(originalFileExtension, 0, originalFileExtension.Length);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(plaintext, 0, plaintext.Length);
                        }
                    }
                }
            }
        }
       
        private string GetOutputFilePath(string inputFile)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string directory = Path.GetDirectoryName(inputFile);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFile);
#pragma warning disable CS8604 // Possible null reference argument.
            string outputFile = Path.Combine(directory, $"{fileNameWithoutExtension}_encrypted");
#pragma warning restore CS8604 // Possible null reference argument.
            return GetUniqueFileName(outputFile);
        }

        private string GetUniqueFileName(string fileName)
        {
            string uniqueFileName = fileName;
            int count = 1;

            while (File.Exists(uniqueFileName))
            {
                string extension = Path.GetExtension(fileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
#pragma warning disable CS8604 // Possible null reference argument.
                uniqueFileName = Path.Combine(Path.GetDirectoryName(fileName), $"{fileNameWithoutExtension} - ({count++}){extension}");
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return uniqueFileName;
        }

    }
}