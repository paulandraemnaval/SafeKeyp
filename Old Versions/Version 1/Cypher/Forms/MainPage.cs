using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cypher.Classes;
using Cypher.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
namespace Cypher.Forms
{
    
    public partial class MainPage : Form
    {
        private bool isDecyptError;
        private int menuState = 1; // 1 = encrypt, 2 = decrypt, 3 = how to use
        private string? selectedDirectory;
        public Account currentAccount;
        public MainPage(Account account)
        {
            InitializeComponent();
            this.PageLabel.Text = "Welcome ";
            this.SelectButton.Visible = true;
            this.SelectButton.Text = "Choose File";
            this.SelectButton.Click += MenuButton_Click;
            this.SelectButton.Visible = false;
            this.SelectedFileName.Visible = false;
            this.ActionButton.Click += ActionButton_Click;
            this.ActionButton.Visible = false;
            this.FeedbackLabel.Text = "";
            this.currentAccount = account;


        }


        private async void ActionButton_Click(object? sender, EventArgs e)
        {
            this.SelectButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.EncryptButton.Enabled = false;
            this.DecryptButton.Enabled = false;
            this.HowtouseButton.Enabled = false;
            string seed = KeyInputBox.Text;
            if (string.IsNullOrEmpty(seed))
            {
                this.FeedbackLabel.Text = "Please enter a seed value";
                this.FeedbackLabel.ForeColor = Color.Red;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
                this.ActionButton.Enabled = true;
                this.EncryptButton.Enabled = true;
                this.DecryptButton.Enabled = true;
                this.HowtouseButton.Enabled = true;
                return;
            }

            byte[] seedBytes = Encoding.UTF8.GetBytes(seed);
            byte[] key;
            using (SHA256 sha256 = SHA256.Create())
                key = sha256.ComputeHash(seedBytes);

            byte[] iv;
            using (Aes aes = Aes.Create())
            {
                aes.GenerateIV();
                iv = aes.IV;
            }

            //encrypt
            if (menuState == 1)
            {
                string encryptedFileName = $"{Path.GetDirectoryName(this.selectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.selectedDirectory)}" + "_encrypted";
                string keyString = BitConverter.ToString(key).Replace("-", "");
                
                EncryptFile(this.selectedDirectory, encryptedFileName, key, iv);
                this.FeedbackLabel.Text = "Encryption Finished";
                this.FeedbackLabel.ForeColor = Color.Green;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
                this.ActionButton.Enabled = true;
                this.EncryptButton.Enabled = true;
                this.DecryptButton.Enabled = true;
                this.HowtouseButton.Enabled = true;
                this.SelectedFileName.Text = "";
                this.KeyInputBox.Text = "";
                this.KeyInputBox.Visible = false;
                this.ActionButton.Visible = false;
            }

            //decrypt
            else if (menuState == 2)
            {
                string encryptedfilecontent = File.ReadAllText(this.selectedDirectory);
                string decryptedFileName = $"{Path.GetDirectoryName(this.selectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.selectedDirectory)}" + "_decrypted";
                DecryptFile(this.selectedDirectory, decryptedFileName, key);
                if(isDecyptError)
                {
                    this.FeedbackLabel.Text = "Error in decryption";
                    this.FeedbackLabel.ForeColor = Color.Red;
                    await Task.Delay(2000);
                    this.FeedbackLabel.Text = "";
                    this.ActionButton.Enabled = true;
                    this.EncryptButton.Enabled = true;
                    this.DecryptButton.Enabled = true;
                    this.HowtouseButton.Enabled = true;

                }
                this.FeedbackLabel.Text = "Decryption Finished";
                this.FeedbackLabel.ForeColor = Color.Green;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
                this.ActionButton.Enabled = true;
                this.EncryptButton.Enabled = true;
                this.DecryptButton.Enabled = true;
                this.HowtouseButton.Enabled = true;
                this.SelectedFileName.Text = "";
                this.KeyInputBox.Text = "";
                this.KeyInputBox.Visible = false;
                this.ActionButton.Visible = false;
            }


            else if (menuState == 3)
            {
                //MessageBox.Show("How to use")
            }


        }


        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if (menuState == 1 || menuState == 2)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Choose a file";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.InitialDirectory = String.IsNullOrEmpty(this.selectedDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : this.selectedDirectory;
                openFileDialog.Multiselect = false;



                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.SelectedFileName.Text = openFileDialog.FileName;
                    this.SelectedFileName.Visible = true;
                    this.selectedDirectory = openFileDialog.FileName;
                    this.ActionButton.Visible = true;
                    this.KeyInputBox.Visible = true;
                    if (menuState == 1)
                    {
                        this.ActionButton.Text = "Encrypt";
                    }
                    else if (menuState == 2)
                    {
                        this.ActionButton.Text = "Decrypt";
                    }

                }
            }

            else if (menuState == 4)
            {
                this.SelectButton.Text = "Open Help";
            }
        }



        private void EncryptButton_MouseEnter(object sender, EventArgs e)
        {
            EncryptButton.BackColor = Color.FromArgb(179, 190, 209);
            EncryptButton.ForeColor = Color.FromArgb(46, 54, 77);
        }

        private void DecryptButton_MouseEnter(object sender, EventArgs e)
        {
            DecryptButton.BackColor = Color.FromArgb(179, 190, 209);
            DecryptButton.ForeColor = Color.FromArgb(46, 54, 77);
        }

        private void HowtouseButton_MouseEnter(object sender, EventArgs e)
        {
            HowtouseButton.BackColor = Color.FromArgb(179, 190, 209);
            HowtouseButton.ForeColor = Color.FromArgb(46, 54, 77);
        }

        private void EncryptButton_MouseLeave(object sender, EventArgs e)
        {
            EncryptButton.BackColor = Color.FromArgb(158, 158, 158);
            EncryptButton.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void DecryptButton_MouseLeave(object sender, EventArgs e)
        {
            DecryptButton.BackColor = Color.FromArgb(158, 158, 158);
            DecryptButton.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void HowtouseButton_MouseLeave(object sender, EventArgs e)
        {
            HowtouseButton.BackColor = Color.FromArgb(158, 158, 158);
            HowtouseButton.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            this.menuState = 1;
            this.ActionButton.Visible = false;
            this.SelectButton.Visible = true;
            this.PageLabel.Text = "Encryption";
            this.SelectButton.Text = "Choose File";
            this.SelectedFileName.Text = "";
            this.selectedDirectory = String.Empty;
            this.KeyInputBox.Visible = false;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            this.menuState = 2;
            this.ActionButton.Visible = false;
            this.SelectButton.Visible = true;
            this.PageLabel.Text = "Decryption";
            this.SelectButton.Text = "Choose File";
            this.selectedDirectory = String.Empty;
            this.SelectedFileName.Text = "";
            this.KeyInputBox.Visible = false;
        }

        private void HowtouseButton_Click(object sender, EventArgs e)
        {
            this.menuState = 4;
            this.ActionButton.Visible = false;
            this.SelectButton.Visible = true;
            this.PageLabel.Text = "How to use";
            this.SelectButton.Text = "Open Help";
            this.selectedDirectory = String.Empty;
            this.SelectedFileName.Text = "";
            this.KeyInputBox.Visible = false;
        }

        private void SeedInputBox_Enter(object sender, EventArgs e)
        {
            this.KeyInputBox.UnderlinedStyle = true;
        }

        private void SeedInputBox_Leave(object sender, EventArgs e)
        {
            this.KeyInputBox.UnderlinedStyle = false;
        }


        //helper methods
        private void EncryptFile(string inputFile, string outputFile, byte[] key, byte[] iv)
        {

            if (File.Exists(outputFile))
            {
                CypherDialog cypherDialog = new CypherDialog();
                cypherDialog.ShowDialog();
                if (!cypherDialog.result)
                {
                    cypherDialog.Close();
                    return;
                }
                
            }

            byte[] plaintext = File.ReadAllBytes(inputFile);
            byte[] originalFileExtension = Encoding.UTF8.GetBytes(Path.GetExtension(inputFile));
            //string keystring = BitConverter.ToString(key).Replace("-", "");
            //MessageBox.Show("ENCRYPT KEY STRING:" + keystring);
            //string ivstring = BitConverter.ToString(iv).Replace("-", "");
            //MessageBox.Show("ENCRYPT IV STRING:" + ivstring);

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                byte[] headerLengthBytes = BitConverter.GetBytes(iv.Length + originalFileExtension.Length);
                fs.Write(headerLengthBytes);
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

        private void DecryptFile(string inputFile, string outputFile, byte[] key)
        {
            this.isDecyptError = false;
            byte[] encryptedData = File.ReadAllBytes(inputFile);
            byte[] headerLengthBytes, extensionBytes, iv;
            int headerLength, extensionLength;

            try
            {
                headerLengthBytes = new byte[4];
                Buffer.BlockCopy(encryptedData, 0, headerLengthBytes, 0, headerLengthBytes.Length);
                headerLength = BitConverter.ToInt16(headerLengthBytes, 0);
                //MessageBox.Show("DECRYPT HEADER LENGTH:" + headerLength);

                iv = new byte[16];
                Buffer.BlockCopy(encryptedData, headerLengthBytes.Length, iv, 0, iv.Length);
                extensionLength = headerLength - iv.Length;

                extensionBytes = new byte[extensionLength];

                Buffer.BlockCopy(encryptedData, headerLengthBytes.Length + iv.Length, extensionBytes, 0, extensionLength);

            }
            catch (ArgumentException)
            {
                this.isDecyptError = true;
                ErrorDialog error = new ErrorDialog();
                error.ShowDialog();
                return;
            }
            string extensionString = Encoding.UTF8.GetString(extensionBytes);


            //MessageBox.Show("DECRYPT EXTENSION STRING:" + extensionString);

            int entireHeaderLength = headerLengthBytes.Length + iv.Length + extensionBytes.Length;
            Buffer.BlockCopy(encryptedData, iv.Length, extensionBytes, 0, extensionLength);
            string originalExtension = Encoding.UTF8.GetString(extensionBytes);


            int encryptedContentLength = encryptedData.Length - entireHeaderLength;
            byte[] encryptedContent = new byte[encryptedContentLength];

            Buffer.BlockCopy(encryptedData, entireHeaderLength, encryptedContent, 0, encryptedContentLength);

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    {
                        using (MemoryStream msDecrypt = new MemoryStream(encryptedContent))
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                try
                                {
                                    cryptoStream.CopyTo(fs);
                                }
                                catch (CryptographicException)
                                {

                                }
                            }
                        }
                    }
                }
            }

            //separated from main try branch bcus it goes on with the file creation but still has error. Deletes file after invalid file decryption.
            string newOutputFile = Path.ChangeExtension(outputFile, extensionString);
            string newOutputFileNoEx = $"{Path.GetDirectoryName(newOutputFile)}\\{Path.GetFileNameWithoutExtension(newOutputFile)}" + "_attempt";
            int i = 1;
            while (File.Exists(newOutputFile))
            {
                string concat = $" - ({i})";
                newOutputFile = $"{newOutputFileNoEx}{concat}";
                newOutputFile = Path.ChangeExtension(newOutputFile, extensionString);
                i++;
            }

            try
            {
                File.Move(outputFile, newOutputFile);
            }
            catch(ArgumentException)
            {
                this.isDecyptError = true;
                ErrorDialog error = new ErrorDialog();
                error.ShowDialog();
                File.Delete(outputFile);
                return;
            }
        }

        private void disableButtons()
        {
            this.EncryptButton.Enabled = false;
            this.DecryptButton.Enabled = false;
            this.HowtouseButton.Enabled = false;
            this.SelectButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.KeyInputBox.Enabled = false;
        }

        private void enableButtons()
        {
            this.EncryptButton.Enabled = true;
            this.DecryptButton.Enabled = true;
            this.HowtouseButton.Enabled = true;
            this.SelectButton.Enabled = true;
            this.ActionButton.Enabled = true;
            this.KeyInputBox.Enabled = true;
        }

        private async void finishedFeedback()
        {
            if(menuState == 1)
            {
                this.FeedbackLabel.Text = "Encryption Attempt done";
                Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
            else if(menuState == 2)
            {
                this.FeedbackLabel.Text = "Decryption attempt done";
                Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
            else if(isDecyptError && menuState == 2)
            {
                this.FeedbackLabel.Text = "File Decryption Error";
                this.FeedbackLabel.ForeColor = Color.Red;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }

        }
    }
}
