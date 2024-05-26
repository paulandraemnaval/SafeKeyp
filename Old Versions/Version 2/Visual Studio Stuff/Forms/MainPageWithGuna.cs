using CypherWithGuna.Classes;
using CypherWithGuna.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna
{
    public partial class MainPageWithGuna : Form
    {
        private int menuState = 1;
        private bool isDecyptError;
        private string selectedDirectory;
        private bool SidePanelExpand = false;

        public MainPageWithGuna()
        {
            InitializeComponent();
            this.PageLabel.Text = "Welcome to SafeKeyp";
            this.PageDescriptionLabel.Text = "An app that encrypts and decrypts files using the AES encryption algorithm\n" +
                "Made by Paul Andrae M. Naval";
            HideControls();
            CollapseSidebar();
        }


        
  
        //EVENTS
        private void SidePanelButton_Click(object sender, EventArgs e)
        {
            if(SidePanelExpand)
                CollapseSidebar();
            else
                ExpandSidebar();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private async void ActionButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            string seed = KeyInputBox.Text;
            if (string.IsNullOrEmpty(seed))
            {   
                await DisplayFeedback(FeedbackType.InvalidKey);
                EnableButtons();
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
                EncryptFile(this.selectedDirectory, key, iv);

                await DisplayFeedback(FeedbackType.EncryptSuccess);
                
                EnableButtons();
                ResetInputs();
            }

            //decrypt
            else if (menuState == 2)
            {
                Task displayFeedback; 
                DecryptFile(this.selectedDirectory, key);
               
                if (isDecyptError)
                {
                    await DisplayFeedback(FeedbackType.DecryptFail);
                    
                    EnableButtons();
                    ResetInputs();
                }
                else
                {
                    await DisplayFeedback(FeedbackType.DecryptSuccess);

                    EnableButtons();
                    ResetInputs();
                }
                
            }


            else if (menuState == 3)
            {
                //MessageBox.Show("How to use")
            }


        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (menuState == 1 || menuState == 2)
            {
                OpenFileDialog openFileDialog = OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.selectedDirectory = openFileDialog.FileName;
                    SelectSuccess();
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
            else if (menuState == 3)
            {
                
                //open help
            }
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            this.menuState = 1;
            if (SidePanelExpand)
                CollapseSidebar();
            InitializePage();

        }
        private void KeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder();
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            this.menuState = 2;
            if(SidePanelExpand)
                CollapseSidebar();
            InitializePage();
        }
        private void KeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder();
        }
        private void HowtouseButton_Click(object sender, EventArgs e)
        {
            if (SidePanelExpand)
                CollapseSidebar();
            this.menuState = 3;
            InitializePage();
        }


        //HELPER FUNCTIONS

        //162 is expanded-collapsed width difference

        //sidebar methods
        private void ExpandSidebar()
        {
            System.Drawing.Image image;
            image = Properties.Resources.icons8_back_arrow_48;
            this.SidePanelButton.Image = image;
            this.SidePanelButton.Width = 222;
            this.SidePanel.Width = 228;
            this.EncryptButton.Width = 222;
            this.DecryptButton.Width = 222;
            this.HowtouseButton.Width = 222;
            this.EncryptButton.Text = "            Encrypt";
            this.DecryptButton.Text = "            Decrypt";
            this.HowtouseButton.Text = "            How To Use";
            this.SidePanelButton.Text = "            Close Sidebar";
            this.SidePanelExpand = true;

            
            this.PageLabel.Location = new Point(238, 59);
            this.PageDescriptionLabel.Location = new Point(243, 104);
            this.SelectButton.Location = new Point(244, 127);
            this.ActionButton.Location = new Point(372, 127);
            this.KeyInputBox.Location = new Point(245, 198);
            this.FeedbackLabel.Location = new Point(241, 236);
            this.SelectedFileName.Location = new Point(240, 273);
        }   
        private void CollapseSidebar()
        {
            System.Drawing.Image image;
            image = Properties.Resources.icons8_menu_48;
            this.SidePanelButton.Image = image;
            this.SidePanelButton.Width = 60;
            this.SidePanel.Width = 66;
            this.EncryptButton.Width = 60;
            this.DecryptButton.Width = 60;
            this.HowtouseButton.Width = 60;
            this.EncryptButton.Text = "";
            this.DecryptButton.Text = "";
            this.HowtouseButton.Text = "";
            this.SidePanelButton.Text = "";
            this.SidePanelExpand = false;

            this.PageLabel.Location = new Point(76, 59);
            this.PageDescriptionLabel.Location = new Point(81, 104);
            this.SelectButton.Location = new Point(82, 127);
            this.ActionButton.Location = new Point(210, 127);
            this.KeyInputBox.Location = new Point(83, 198);
            this.FeedbackLabel.Location = new Point(79, 236);
            this.SelectedFileName.Location = new Point(78, 273);

        }


        //page methods
        private void HideControls()
        {
            this.ActionButton.Visible = false;
            this.KeyInputBox.Visible = false;
            this.SelectedFileName.Visible = false;
            this.FeedbackLabel.Text = "";
            this.SelectButton.Visible = false;
        }
        private void InitializePage()
        {
            
            if (menuState == 1 || menuState == 2)
            {
                this.SelectButton.Text = "Select File";
            }
            else if(menuState == 3)
            {
                this.SelectButton.Text = "Open Help";
            }

            if(menuState == 1)
            {
                this.PageDescriptionLabel.Text = "Encrypt your file with a key using the AES Encryption algorithm";
                this.PageLabel.Text = "Encrypt";
                this.ActionButton.Text = "Encrypt";
                CheckPlaceholder();
                HideControls();
            }
            else if(menuState == 2)
            {
                this.PageDescriptionLabel.Text = "Decrypt your file with a key using the AES Decryption algorithm";
                this.PageLabel.Text = "Decrypt";
                this.ActionButton.Text = "Decrypt";
                CheckPlaceholder();
                HideControls();
            }
            else if(menuState == 3)
            {
                this.PageDescriptionLabel.Text =
                    "How to use SafeKeyp:\n\n" +
                    "ENCRYPTION:\n" +
                    "1.  Navigate to the encryption page\n" +
                    "2. Select the file you want to encrypt using the 'Select' button\n" +
                    "3. Once file is selected, enter a key to your file\n" +
                    "4. Once encryption is finished, the encrypted file will be found in the same\n" +
                    "directory as the chosen file.\n\n" +
                    "DECRYPTION:\n" +
                    "1.  Navigate to the decryption page\n" +
                    "2. Select the file you want to decrypt using the 'Select' button\n" +
                    "3. Once the file is selected, enter the key used to encrypt the file\n" +
                    "4. Once decryption is finished, the decrypted file will be found in the same\n" +
                    "directory as the chosed file\n\n";

                this.PageLabel.Text = "How To Use";
                HideControls();
            }
            this.SelectButton.Visible = true;
        }
        private void CheckPlaceholder()
        {
            if (this.KeyInputBox.Text.Trim() == "Key to encrypt file with")
            {
                this.KeyInputBox.Text = "";
            }
            if (this.KeyInputBox.Text.Trim() == "")
            {
                this.KeyInputBox.Text = "Key to encrypt file with";
            }
        }
        private void EnableButtons()
        {
            this.ActionButton.Enabled = true;
            this.EncryptButton.Enabled = true;
            this.DecryptButton.Enabled = true;
            this.HowtouseButton.Enabled = true;
            this.SelectButton.Enabled = true;
        }
        private void DisableButtons()
        {
            this.SelectButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.EncryptButton.Enabled = false;
            this.DecryptButton.Enabled = false;
            this.HowtouseButton.Enabled = false;

        }
        private void ResetInputs()
        {
            this.selectedDirectory = String.Empty;
            this.KeyInputBox.Text = "";
            this.SelectedFileName.Text = "";
            this.KeyInputBox.Visible = false;
            this.ActionButton.Visible = false;
        }
        private void SelectSuccess()
        {
            this.SelectedFileName.Text = this.selectedDirectory;
            this.SelectedFileName.Visible = true;
            this.ActionButton.Visible = true;
            this.KeyInputBox.Visible = true;
        }
        private async Task DisplayFeedback(FeedbackType result)
        {
            
            if (result == FeedbackType.InvalidKey)
            {
                this.FeedbackLabel.Text = "Please enter a seed value";
                this.FeedbackLabel.ForeColor = Color.Red;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
            else if (result == FeedbackType.EncryptSuccess)
            {
                this.FeedbackLabel.Text = "Encryption Finished";
                this.FeedbackLabel.ForeColor = Color.Green;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
            else if (result == FeedbackType.DecryptFail)
            {
                this.FeedbackLabel.Text = "Error in decryption";
                this.FeedbackLabel.ForeColor = Color.Red;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
            else if (result == FeedbackType.DecryptSuccess)
            {
                this.FeedbackLabel.Text = "Decryption Finished";
                this.FeedbackLabel.ForeColor = Color.Green;
                await Task.Delay(2000);
                this.FeedbackLabel.Text = "";
            }
        }


        //file methods
        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a file";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.InitialDirectory = String.IsNullOrEmpty(this.selectedDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : this.selectedDirectory;
            openFileDialog.Multiselect = false;
            return openFileDialog;
        }
        private void EncryptFile(string inputFile, byte[] key, byte[] iv)
        {
            string outputFile = $"{Path.GetDirectoryName(this.selectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.selectedDirectory)}" + "_encrypted";
            if (File.Exists(outputFile))
            {
                SafeKeypDialog safeKeypDialog = new SafeKeypDialog();
                safeKeypDialog.ShowDialog();
                if (!safeKeypDialog.result)
                {
                    safeKeypDialog.Close();
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
        private void DecryptFile(string inputFile, byte[] key)
        {
            this.isDecyptError = false;
            string outputFile = $"{Path.GetDirectoryName(this.selectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.selectedDirectory)}" + "_decrypted";
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
                            try
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    cryptoStream.CopyTo(fs);

                                }
                            }
                            catch(CryptographicException)
                            {
                                this.isDecyptError = true;
                                ErrorDialog error = new ErrorDialog();
                                error.ShowDialog();
                                return;
                            }
                        }
                    }
                }
            }

            //separated from main try branch bcus it goes on with the file creation but still has error. Deletes file after invalid file decryption.
            string newOutputFile = Path.ChangeExtension(outputFile, extensionString);
            string newOutputFileNoEx;
            try
            {
                newOutputFileNoEx = $"{Path.GetDirectoryName(newOutputFile)}\\{Path.GetFileNameWithoutExtension(newOutputFile)}" + "_attempt";
            }
            catch (ArgumentException)
            {
                this.isDecyptError = true;
                ErrorDialog error = new ErrorDialog();
                error.ShowDialog();
                return;
            }


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
            catch (ArgumentException)
            {
                this.isDecyptError = true;
                ErrorDialog error = new ErrorDialog();
                error.ShowDialog();
                File.Delete(outputFile);
                return;
            }
        }   
    }
}
