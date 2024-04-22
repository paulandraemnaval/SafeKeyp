using CypherWithGuna.Classes;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna.Forms
{
    public partial class EncryptUserControl : UserControl
    {
        public string SelectedDirectory;
        private string InitialDirectory;
        public string seed;
        public EncryptUserControl()
        {
            InitializeComponent();
            HideControls();
        }

        // events
        private void SelectButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
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
        private void ActionButton_Click(object sender, EventArgs e)
        {
            DisableButtons();

            string seed = KeyInputBox.Text;
            this.seed = seed;
            if (string.IsNullOrEmpty(seed))
            {
                DisplayFeedback(FeedbackType.InvalidKey);
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
            if (CheckKeyMatch() == false)
            {
                DisplayFeedback(FeedbackType.EncryptKeyNotMatch);
                EnableButtons();
                return;
            }

            string outputFile = $"{Path.GetDirectoryName(this.SelectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}" + "_encrypted";
            if (File.Exists(outputFile))
            {
                if (!ConfirmEncryption())
                {
                    DisplayFeedback(FeedbackType.EncryptAborted);
                    return;
                }
            }


            if (this.FileRecoveryCheckBox.Checked)
            {
                SetupFileRecoveryForm setup = new SetupFileRecoveryForm(this);
                setup.ShowSetupFileRecoveryForm();
                if (!setup.Result)
                {
                    setup.Close();
                    EnableButtons();
                    return;
                }

                    EncryptFile(this.SelectedDirectory, key, iv);
                    CheckIfDelete();
                    ClearSelectedDirectory();
            }
            else 
            {
                EncryptFile(this.SelectedDirectory, key, iv);
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
        private void ConfirmKeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder(ConfirmKeyInputBox, "Confirm Key");
        }
        private void ConfirmKeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder(ConfirmKeyInputBox, "Confirm Key");
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
        private void ConfirmKeyPeekButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ConfirmKeyInputBox.UseSystemPasswordChar = false;
        }
        private void ConfirmKeyPeekButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ConfirmKeyInputBox.UseSystemPasswordChar = true;
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
            this.ConfirmKeyInputBox.Visible = true;
            this.ConfirmKeyPeekButton.Visible = true;
            this.FileRecoveryCheckBox.Visible = true;
        }
        private void DisableButtons()
        {
            this.SelectButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.KeyPeekButton.Enabled = false;
            this.ConfirmKeyPeekButton.Enabled = false;

        }
        
        private void DisplayFeedback(FeedbackType result)
        {
            if(result == FeedbackType.EncryptAborted)
            {
                this.FeedbackLabel.Text = "Encryption Aborted";
                this.FeedbackLabel.ForeColor = Color.Red;
                this.EncryptUserControlTimer.Start();

            }
            else if (result == FeedbackType.InvalidKey)
            {
                this.FeedbackLabel.Text = "Please enter a seed value";
                this.FeedbackLabel.ForeColor = Color.Red;
                this.EncryptUserControlTimer.Start();
            }
            else if (result == FeedbackType.EncryptKeyNotMatch)
            {
                this.FeedbackLabel.Text = "Keys do not match";
                this.FeedbackLabel.ForeColor = Color.Red;
                this.EncryptUserControlTimer.Start();
            }
            else if (result == FeedbackType.EncryptSuccess)
            {
                this.FeedbackLabel.Text = "Encryption Finished";
                this.FeedbackLabel.ForeColor = Color.Green;
                this.EncryptUserControlTimer.Start();
                ResetInputs();
                HideControls();
            }

        }
        private void EnableButtons()
        {
            this.ActionButton.Enabled = true;
            this.SelectButton.Enabled = true;
            this.KeyPeekButton.Enabled = true;
            this.ConfirmKeyPeekButton.Enabled = true;
        }
        private bool CheckKeyMatch()
        {
            return this.KeyInputBox.Text == this.ConfirmKeyInputBox.Text;
        }
        private void  EncryptFile(string inputFile, byte[] key, byte[] iv)
        {
            string outputFile = $"{Path.GetDirectoryName(this.SelectedDirectory)}\\{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}" + "_encrypted";
            
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
            DisplayFeedback(FeedbackType.EncryptSuccess);
        }
        public void ResetInputs()
        {
            this.KeyInputBox.Text = "Enter Key";
            this.ConfirmKeyInputBox.Text = "Confirm Key";
            this.SelectedFileName.Text = "";
            this.KeyInputBox.UseSystemPasswordChar = false;
            this.ConfirmKeyInputBox.UseSystemPasswordChar = false;
            this.DeleteRadioButton.Checked = false;
            this.FileRecoveryCheckBox.Checked = false;

        }
        public void HideControls()
        {
            this.ActionButton.Visible = false;
            this.KeyInputBox.Visible = false;
            this.KeyPeekButton.Visible = false;
            this.ConfirmKeyInputBox.Visible = false;
            this.ConfirmKeyPeekButton.Visible = false;
            this.DeleteRadioButton.Visible = false;
            this.SelectedFileName.Visible = false;
            this.FileRecoveryCheckBox.Visible = false;
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
            if (this.ConfirmKeyInputBox.Text.Trim() == ph)
            {
                this.ConfirmKeyInputBox.UseSystemPasswordChar = true;
                this.ConfirmKeyInputBox.Text = "";
            }
            else if (this.ConfirmKeyInputBox.Text.Trim() == "")
            {
                this.ConfirmKeyInputBox.UseSystemPasswordChar = false;
                this.ConfirmKeyInputBox.Text = ph;

            }
        }
        private void CheckPeek()
        {
            if (this.KeyInputBox.Text == "Enter Key" || this.KeyInputBox.Text.Trim() == String.Empty)
                this.KeyPeekButton.Enabled = false;
            else
                this.KeyPeekButton.Enabled = true;
            if (this.ConfirmKeyInputBox.Text == "Confirm Key" || this.ConfirmKeyInputBox.Text.Trim() == String.Empty)
                this.ConfirmKeyPeekButton.Enabled = false;
            else
                this.ConfirmKeyPeekButton.Enabled = true;
        } 
        private bool ConfirmEncryption()
        {
            SafeKeypDialog safeKeypDialog = new SafeKeypDialog(this.Location, this.Width, this.Height);
            safeKeypDialog.showSafeKeypDialog();
            if (!safeKeypDialog.result)
            {
                safeKeypDialog.Close();
                return false;
            }
            else
            {
                safeKeypDialog.Close();
                return true;
            }

        }
        private void EncryptUserControlTimer_Tick(object sender, EventArgs e)
        {
            EnableButtons();
            this.FeedbackLabel.Text = "";
            this.EncryptUserControlTimer.Stop();
        }

       
    }
}
