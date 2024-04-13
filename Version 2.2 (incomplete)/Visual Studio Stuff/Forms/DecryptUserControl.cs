using CypherWithGuna.Classes;
using Guna.UI.WinForms;
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

namespace CypherWithGuna.Forms
{
    public partial class DecryptUserControl : UserControl
    {
        private string SelectedDirectory;
        private string InitialDirectory;
        private bool isDecyptError;
        public DecryptUserControl()
        {
            InitializeComponent();
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.SelectedDirectory = openFileDialog.FileName;
                    this.InitialDirectory = Path.GetDirectoryName(this.SelectedDirectory);
                    SelectSuccess();
                }
            }
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

            //decrypt


            DisableButtons();
            DecryptFile(this.SelectedDirectory, key);

            if (isDecyptError)
            {
                await DisplayFeedback(FeedbackType.DecryptFail);
                ResetKeyInputBox();
                EnableButtons();
                return;
            }
            else
            {
                await DisplayFeedback(FeedbackType.DecryptSuccess);

                EnableButtons();
                ResetInputs();
                HideControls();
                CheckIfDelete();
                ClearSelectedDirectory();
            }
        }
        private void KeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder(KeyInputBox, "Enter Key");
        }
        private void KeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder(KeyInputBox, "Enter Key");
        }
        private void KeyInputBox_TextChanged(object sender, EventArgs e)
        {
            CheckPeek();
        }
        
        private void ConfirmKeyInputBox_TextChanged(object sender, EventArgs e)
        {
            CheckPeek();
        }
        private void PeekButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.KeyInputBox.UseSystemPasswordChar = false;
        }
        private void PeekButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.KeyInputBox.UseSystemPasswordChar = true;
        }
        





        // helper methods
        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a file";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.InitialDirectory = String.IsNullOrEmpty(this.SelectedDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : this.InitialDirectory;
            openFileDialog.Multiselect = false;
            return openFileDialog;
        }
        private void SelectSuccess()
        {
            this.DeleteRadioButton.Text = "Delete original file after decryption";
            this.SelectedFileName.Text = this.SelectedDirectory;
            ShowControls();
        }
        private void ShowControls()
        {
            this.SelectedFileName.Visible = true;
            this.ActionButton.Visible = true;
            this.KeyPeekButton.Visible = true;
            this.DeleteRadioButton.Visible = true;
            this.KeyInputBox.Visible = true;
            
        }
        private void DisableButtons()
        {
            this.SelectButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.KeyPeekButton.Enabled = false;
            

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
            else if (result == FeedbackType.EncryptKeyNotMatch)
            {
                this.FeedbackLabel.Text = "Keys do not match";
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
        }
        private void EnableButtons()
        {
            this.ActionButton.Enabled = true;
            this.SelectButton.Enabled = true;
            this.KeyPeekButton.Enabled = true;
            
        }

        private void DecryptFile(string inputFile, byte[] key)
        {
            this.isDecyptError = false;
            string outputFile = $"{Path.GetDirectoryName(this.SelectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}" + "_decrypted";
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
                SafeKeypErrorPopup error = new SafeKeypErrorPopup(this.Location, this.Width, this.Height);
                error.showSafeKeypErrorPopup();
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
                            catch (CryptographicException)
                            {
                                this.isDecyptError = true;
                                SafeKeypErrorPopup error = new SafeKeypErrorPopup(this.Location, this.Width, this.Height);
                                error.showSafeKeypErrorPopup();
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
                SafeKeypErrorPopup error = new SafeKeypErrorPopup(this.Location, this.Width, this.Height);
                error.showSafeKeypErrorPopup();
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
                SafeKeypErrorPopup error = new SafeKeypErrorPopup(this.Location, this.Width, this.Height);
                error.showSafeKeypErrorPopup();
                return;
            }
        }

        private void ResetInputs()
        {
            this.KeyInputBox.Text = "Enter Key";
            this.SelectedFileName.Text = "";
        }
        private void HideControls()
        {
            this.ActionButton.Visible = false;
            this.KeyInputBox.Visible = false;
            this.KeyPeekButton.Visible = false;
            this.DeleteRadioButton.Visible = false;
            this.SelectedFileName.Visible = false;
            this.FeedbackLabel.Text = "";
        }
        private void CheckIfDelete()
        {
            if (this.DeleteRadioButton.Checked)
                File.Delete(this.SelectedDirectory);
        }
        private void ClearSelectedDirectory()
        {
            this.SelectedDirectory = String.Empty;
        }
        private void CheckPlaceholder(GunaLineTextBox t, string ph)
        {
            if (this.KeyInputBox.Text.Trim() == ph)
            {
                this.KeyInputBox.UseSystemPasswordChar = true;
                this.KeyInputBox.Text = "";

            }
            else if (this.KeyInputBox.Text.Trim() == "")
            {
                this.KeyInputBox.UseSystemPasswordChar = false;
                this.KeyInputBox.Text = ph;
            }
        }
        private void CheckPeek()
        {
            if (this.KeyInputBox.Text == "Enter Key" || this.KeyInputBox.Text.Trim() == String.Empty)
                this.KeyPeekButton.Enabled = false;
            else
                this.KeyPeekButton.Enabled = true;
        }
        private void ResetKeyInputBox()
        {
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.UseSystemPasswordChar = false;
        }

    }


}
