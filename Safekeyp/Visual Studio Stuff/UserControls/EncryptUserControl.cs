using CypherWithGuna.Classes;
using Google.Cloud.Firestore;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string SelectedDirectory;
        private string DestinationDirectory;
        public EncryptUserControl()
        {
            InitializeComponent();
            CheckPeek();
            
        }

        // events
        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(openFileDialog.FileName);
                    long fileSize = fi.Length;
                    double filesizeGB = fileSize / (1024*1024*1024);
                    if(filesizeGB >= 2)
                    {
                        DisplayFeedback(FeedbackType.FileTooBig);
                        return;
                    }
                    this.SelectedDirectory = openFileDialog.FileName;
                    SelectSuccess();
                }
            }
        }
        private void ActionButton_Click(object sender, EventArgs e)
        {
           DisableButtons();
            if (this.SelectedDirectory == null)
            {
                DisplayFeedback(FeedbackType.NoSelectedFile);
                return;
            }
            if (this.KeyInputBox.Text == "Enter Key" || this.ConfirmKeyInputBox.Text == "Confirm Key")
            {
                DisplayFeedback(FeedbackType.InvalidKey);
                return;
            }
            if (this.KeyInputBox.Text != this.ConfirmKeyInputBox.Text)
            {
                DisplayFeedback(FeedbackType.EncryptKeyNotMatch);
                return;
            }
            if (this.DestinationDirectory == null)
            {
                DisplayFeedback(FeedbackType.NoSelectedDestinationDirectory);
                return;
            }
            byte[] seedBytes = Encoding.UTF8.GetBytes(this.KeyInputBox.Text);
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
           
            string outputFile = Path.Combine(this.DestinationDirectory, $"{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}" + "_encrypted");
            if (File.Exists(outputFile))
            {
                if (!ConfirmEncryption())
                {
                    DisplayFeedback(FeedbackType.EncryptAborted);
                    return;
                }
            }
            EncryptFile(this.SelectedDirectory, key, iv);
            CheckIfDelete();
            ClearDirectories();
        }
        private void KeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder1("Enter Key");
            this.KeyInputBox.BackColor = Color.Lime;
            this.KeyInputBox.ForeColor = Color.Black;
        }
        private void KeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder1("Enter Key");
            this.KeyInputBox.BackColor = Color.Black;
            this.KeyInputBox.ForeColor = Color.Lime;
        }
        private void KeyInputBox_TextChanged(object sender, EventArgs e)
        {
            CheckPeek();
        }
        private void ConfirmKeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder2("Confirm Key");
            this.ConfirmKeyInputBox.BackColor = Color.Lime;
            this.ConfirmKeyInputBox.ForeColor = Color.Black;
        }
        private void ConfirmKeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder2("Confirm Key");
            this.ConfirmKeyInputBox.BackColor = Color.Black;
            this.ConfirmKeyInputBox.ForeColor = Color.Lime;
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
        private void EncryptUserControlTimer_Tick(object sender, EventArgs e)
        {
            this.FeedbackLabel.Text = "";
            EnableButtons();
            this.EncryptUserControlTimer.Stop();
        }

        private void EncryptSuccessTimer_Tick(object sender, EventArgs e)
        {
            ResetInputs();
            this.EncryptSuccessTimer.Stop();
        }


        private void SelectDestinationButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    this.DestinationDirectory = fbd.SelectedPath;
                    this.DestinationDirectoryLabel.Text = this.DestinationDirectory;
                    this.DestinationDirectoryLabel.Visible = true;

                }
                else
                    return;
            }
        }







        // helper methods
        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a file";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.InitialDirectory = String.IsNullOrEmpty(this.SelectedDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : Path.GetDirectoryName(this.SelectedDirectory);
            openFileDialog.Multiselect = false;
            return openFileDialog;
        }
        private void SelectSuccess()
        {
            this.SelectedFileName.Text = Path.GetFileName(this.SelectedDirectory);
            
        }
        
        private void DisableButtons()
        {
            this.KeyInputBox.Enabled = false;
            this.ConfirmKeyInputBox.Enabled = false;
            this.SelectFileButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.DeleteRadioButton.Enabled = false;
            this.SelectDestinationButton.Enabled = false;
            this.ActionButton.Enabled = false;
            CheckPeek();
        }

        private void EnableButtons()
        {
            this.KeyInputBox.Enabled = true;
            this.ConfirmKeyInputBox.Enabled = true;
            this.SelectFileButton.Enabled = true;
            this.ActionButton.Enabled = true;
            this.DeleteRadioButton.Enabled = true;
            this.SelectDestinationButton.Enabled = true;
            this.ActionButton.Enabled = true;
            CheckPeek();
        }
        
        private void DisplayFeedback(FeedbackType result)
        {
            if (result == FeedbackType.NoSelectedFile)
            {
                this.FeedbackLabel.Text = "Please select a file to encrypt";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if (result == FeedbackType.InvalidKey)
            {
                this.FeedbackLabel.Text = "Please enter a key";
                this.FeedbackLabel.ForeColor = Color.Red;
                
            }
            else if (result == FeedbackType.EncryptKeyNotMatch)
            {
                this.FeedbackLabel.Text = "Keys do not match";
                this.FeedbackLabel.ForeColor = Color.Red;
                
            }
            else if (result == FeedbackType.EncryptSuccess)
            {
                
                this.FeedbackLabel.Text = "Encryption Finished";
                this.FeedbackLabel.ForeColor = Color.Lime;
                this.EncryptSuccessTimer.Start();
                
            }
            else if (result == FeedbackType.NoSelectedDestinationDirectory)
            {
                this.FeedbackLabel.Text = "Please select a destination directory";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if(result == FeedbackType.FileTooBig)
            {
                this.FeedbackLabel.Text = "File selected too big";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            this.EncryptUserControlTimer.Start();

        }
        public void  EncryptFile(string inputFile, byte[] key, byte[] iv)
        {
            string outputFile = Path.Combine(this.DestinationDirectory, $"{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}_encrypted");
            string test = outputFile;
            int i = 1;

            while (File.Exists(test))
            {
                string concat = $" - ({i++})";
                test = $"{outputFile}{concat}";
                test = Path.Combine(this.DestinationDirectory, Path.GetFileName(test));
            }

            outputFile = test;

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
            this.SelectedFileName.Text = "No File Selected";
            this.KeyInputBox.UseSystemPasswordChar = false;
            this.ConfirmKeyInputBox.UseSystemPasswordChar = false;
            this.DeleteRadioButton.Checked = false;
            this.DestinationDirectoryLabel.Text = "";
            
        }
        private void CheckIfDelete()
        {
            if (this.DeleteRadioButton.Checked)
            {
                byte[] filebytes = File.ReadAllBytes(this.SelectedDirectory);
                for (int i = 0; i < filebytes.Length; i++)
                {
                    filebytes[i] = 0x00;
                }
                File.Delete(this.SelectedDirectory);
            }
        }
        private void ClearDirectories()
        {
            this.SelectedDirectory = null;
            this.DestinationDirectory = null;
        }
        private void CheckPlaceholder1(string ph)
        {
            
            if (this.KeyInputBox.Text.Trim() == ph)
            {
                this.KeyInputBox.UseSystemPasswordChar = true;
                this.KeyInputBox.Text = "";
                return;
            }
            else if (string.IsNullOrEmpty(this.KeyInputBox.Text.Trim()))
            {
                this.KeyInputBox.UseSystemPasswordChar = false;
                this.KeyInputBox.Text = ph;
                return;
            }
        }

        private void CheckPlaceholder2(string ph)
        {
            if (this.ConfirmKeyInputBox.Text.Trim() == ph)
            {
                this.ConfirmKeyInputBox.UseSystemPasswordChar = true;
                this.ConfirmKeyInputBox.Text = "";
                return;
            }
            else if (string.IsNullOrEmpty(this.ConfirmKeyInputBox.Text.Trim()))
            {
                this.ConfirmKeyInputBox.UseSystemPasswordChar = false;
                this.ConfirmKeyInputBox.Text = ph;
                return;
            }
        }
        private void CheckPeek()
        {
            if (this.KeyInputBox.Text.Trim() == "Enter Key" || this.KeyInputBox.Text.Trim() == String.Empty)
            {
                this.KeyPeekButton.BaseColor = Color.Black;
                this.KeyPeekButton.Enabled = false;
            }
            else
            {
                this.KeyPeekButton.BaseColor = Color.Lime;
                this.KeyPeekButton.Enabled = true;
            }
            if (this.ConfirmKeyInputBox.Text.Trim() == "Confirm Key" || this.ConfirmKeyInputBox.Text.Trim() == String.Empty)
            {
                this.ConfirmKeyPeekButton.BaseColor = Color.Black;
                this.ConfirmKeyPeekButton.Enabled = false;
            }
            else
            {
                this.ConfirmKeyPeekButton.BaseColor = Color.Lime;
                this.ConfirmKeyPeekButton.Enabled = true;
            }
                
        } 
        private bool ConfirmEncryption()
        {
            SafeKeypDialog safeKeypDialog = new SafeKeypDialog();
            safeKeypDialog.showSafeKeypDialog(((EncryptForm)this.Parent.Parent).mp);
            if (safeKeypDialog.result)
            {
                safeKeypDialog.Close();
                return true;
            }
            else
            {
                safeKeypDialog.Close();
                return false;
            }

        }
        

        private FolderBrowserDialog FolderBrowserDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select a folder";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = String.IsNullOrEmpty(this.DestinationDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : this.DestinationDirectory;
            return folderBrowserDialog;
        }

        
    }
}
