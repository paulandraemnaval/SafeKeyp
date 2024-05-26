using Cypher.Classes;
using Cypher.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cypher
{
    public partial class FileSafeItem : UserControl
    {
        private string directory;
        private int isEncrypted; //1 = encrypted, 0 = not encrypted
        private Account currentAccount;
        public FileSafeItem(string directory, MainPage mainpage)
        {
            this.isEncrypted = 0;
            this.FileNameLabel.Text = Path.GetFileName(directory);
            this.ItemIcon.Image = Image.FromFile(directory);
            this.directory = directory;
            InitializeComponent();
            this.currentAccount = mainpage.currentAccount;
        }

        private string _fileName;
        private string _fileDescription;
        private Image _fileIcon;
        private int state;

        public int stateValue
        {
            get { return state; }
            set { state = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                FileNameLabel.Text = value;
            }
        }

        public string FileDescription
        {
            get { return _fileDescription; }
            set
            {
                _fileDescription = value;
                ActionFeedback.Text = value;
            }
        }

        public Image ItemImage
        {
            get { return _fileIcon; }
            set
            {
                _fileIcon = value;
                ItemIcon.Image = value;
            }
        }


        private async void EncryptFile()
        {
            byte[] key;
            byte[] iv;
            this.currentAccount.DeriveEncryptionKeys(out key, out iv);
            this.ActionButton.Enabled = false;
            this.RemoveButton.Enabled = false;
            this.ActionFeedback.Text = "Encrypting...";
            this.ActionFeedback.ForeColor = Color.Black;
            this.ActionFeedback.Visible = true;
            string encryptedFileName = $"{Path.GetDirectoryName(this.directory)}\\{Path.GetFileNameWithoutExtension(this.directory)}" + "_encrypted" + $"{Path.GetExtension(this.directory)}";
            EncryptFileHelper(this.directory, encryptedFileName, key, iv);
            await Task.Delay(1000);
            this.ActionFeedback.Text = "Encrypted!";
            this.ActionFeedback.ForeColor = Color.Green;
            this.isEncrypted = 1;
            await Task.Delay(1000);
            this.ActionFeedback.Text = "";
            this.ActionFeedback.Visible = false;
            this.ActionButton.Enabled = true;
            this.RemoveButton.Enabled = true;
        }

        private void EncryptFileHelper(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
           
            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                        {
                            //cryptoStream.Write(plaintext, 0, plaintext.Length);
                        }
                    }
                }
            }
            //File.Delete(inputFile);
        }
        private async void DecryptFile()
        {
            byte[] key;
            byte[] iv;
            this.currentAccount.DeriveEncryptionKeys(out key, out iv);
            this.ActionButton.Enabled = false;
            this.RemoveButton.Enabled = false;
            this.ActionFeedback.Text = "Decrypting...";
            this.ActionFeedback.ForeColor = Color.Black;
            this.ActionFeedback.Visible = true;
            string decryptedFileName = $"{Path.GetDirectoryName(this.directory)}\\{Path.GetFileNameWithoutExtension(this.directory)}" + "_decrypted" + $"{Path.GetExtension(this.directory)}";
            DecryptFileHelper(this.directory, decryptedFileName, key, iv);
            await Task.Delay(1000);
            this.ActionFeedback.Text = "Decrypted!";
            this.ActionFeedback.ForeColor = Color.Green;
            this.isEncrypted = 0;
            await Task.Delay(1000);
            this.ActionFeedback.Text = "";
            this.ActionFeedback.Visible = false;
            this.ActionFeedback.Visible = true;
            this.ActionButton.Enabled = true;
            this.RemoveButton.Enabled = true;

        }
        private void DecryptFileHelper(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
            //byte[] ciphertext = File.ReadAllBytes(inputFile);
            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(fs, decryptor, CryptoStreamMode.Write))
                        {
                            //cryptoStream.Write(ciphertext, 0, ciphertext.Length);
                        }
                    }
                }
            }
           // File.Delete(inputFile);
        }
        private void ActionButton_Click(object sender, EventArgs e)
        {
            if(this.isEncrypted == 0)
            {
                this.ActionButton.Text = "Encrypt";
                EncryptFile();
            }
            else
            {
                this.ActionButton.Text = "Decrypt";
                DecryptFile();
            }
        }

    
    }
}
