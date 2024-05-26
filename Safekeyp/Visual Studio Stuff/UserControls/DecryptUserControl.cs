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
        private string DestinationDirectory;
        public DecryptUserControl()
        {
            InitializeComponent();
            CheckPeek();
           
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(openFileDialog.FileName);
                    long fileSize = fi.Length;
                    double filesizeGB = fileSize / (1024 * 1024 * 1024);
                    if (filesizeGB >= 2)
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
            bool isDecryptError = false; 
            DisableButtons();

            if (this.SelectedDirectory == null)
            {
                DisplayFeedback(FeedbackType.NoSelectedFile);
                return;
            }

            if (this.KeyInputBox.Text == "Enter Key")
            {
                DisplayFeedback(FeedbackType.InvalidKey);
                return;
            }
            
            if(this.DestinationDirectory == null)
            {
                DisplayFeedback(FeedbackType.NoSelectedDestinationDirectory);
                return;
            }

            string seed = this.KeyInputBox.Text;
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
            try
            {
                DecryptFile(this.SelectedDirectory, key);

            }
            catch (CryptographicException)
            {
                isDecryptError = true;
            }

            catch (ArgumentException)
            {
                isDecryptError = true;  
            }
            catch (OverflowException)
            {
                isDecryptError = true;
            }
            if (isDecryptError)
            {
                string path = Path.Combine(this.DestinationDirectory, Path.GetFileNameWithoutExtension(this.SelectedDirectory) + "_decrypted");
                File.Delete(path);
                SafeKeypErrorPopup error = new SafeKeypErrorPopup();
                error.showSafeKeypErrorPopup(((DecryptForm)this.Parent).mp);
                DisplayFeedback(FeedbackType.DecryptFail);
                ResetKeyInputBox();
                return;
            }
            DisplayFeedback(FeedbackType.DecryptSuccess);
            CheckIfDelete();
            ClearSelectedDirectory();

        }
        private void KeyInputBox_Enter(object sender, EventArgs e)
        {
            CheckPlaceholder("Enter Key");
            this.KeyInputBox.BackColor = Color.Lime;
            this.KeyInputBox.ForeColor = Color.Black;
        }
        private void KeyInputBox_Leave(object sender, EventArgs e)
        {
            CheckPlaceholder("Enter Key");
            this.KeyInputBox.BackColor = Color.Black;
            this.KeyInputBox.ForeColor = Color.Lime;
        }
        private void KeyInputBox_TextChanged(object sender, EventArgs e)
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
            this.SelectDestinationButton.Enabled = false;
            this.ActionButton.Enabled = false;
            this.KeyInputBox.Enabled = false;
            this.KeyPeekButton.Enabled = false;
            this.SelectDestinationButton.Enabled = false;
        }
        private void DisplayFeedback(FeedbackType result)
        {

            if (result == FeedbackType.InvalidKey)
            {
                this.FeedbackLabel.Text = "Please enter a key";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if (result == FeedbackType.DecryptSuccess)
            {
                this.FeedbackLabel.Text = "Decryption Finished";
                this.FeedbackLabel.ForeColor = Color.Lime;
                this.DecryptSuccessTimer.Start();
            }
            else if (result == FeedbackType.DecryptFail)
            {
                this.FeedbackLabel.Text = "Decryption Failed";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if (result == FeedbackType.NoSelectedDestinationDirectory)
            {
                this.FeedbackLabel.Text = "Please select a destination directory";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if (result == FeedbackType.NoSelectedFile)
            {
                this.FeedbackLabel.Text = "Please select a file to decrypt";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            else if (result == FeedbackType.FileTooBig)
            {
                this.FeedbackLabel.Text = "File selected too big";
                this.FeedbackLabel.ForeColor = Color.Red;
            }
            this.DecryptUserControlTimer.Start();
        }
        private void EnableButtons()
        {
            this.ActionButton.Enabled = true;
            this.SelectDestinationButton.Enabled = true;
            this.SelectDestinationButton.Enabled = true;
            this.KeyInputBox.Enabled = true;
            CheckPeek();
        }

        public void DecryptFile(string inputFile, byte[] key)
        {
            string outputFile = Path.Combine(this.DestinationDirectory, $"{Path.GetFileNameWithoutExtension(this.SelectedDirectory)}_decrypted");
            byte[] encryptedData = File.ReadAllBytes(inputFile);
            byte[] headerLengthBytes, extensionBytes, iv;
            int headerLength, extensionLength;

            //byte[] length is 4 bcus Bitconverter.GetBytes returns 4 bytes
            headerLengthBytes = new byte[4];
            Buffer.BlockCopy(encryptedData, 0, headerLengthBytes, 0, headerLengthBytes.Length);
            headerLength = BitConverter.ToInt16(headerLengthBytes, 0);
            //MessageBox.Show("DECRYPT HEADER LENGTH:" + headerLength);

            //iv is always 16 bytes for AES
            iv = new byte[16];
            Buffer.BlockCopy(encryptedData, headerLengthBytes.Length, iv, 0, iv.Length);
            extensionLength = headerLength - iv.Length;

            //byte[] length varies here bcus extensions can vary in length
            extensionBytes = new byte[extensionLength];

            Buffer.BlockCopy(encryptedData, headerLengthBytes.Length + iv.Length, extensionBytes, 0, extensionLength);

            string extensionString = Encoding.UTF8.GetString(extensionBytes);


            //MessageBox.Show("DECRYPT EXTENSION STRING:" + extensionString);

            //entire header length is computed to determine where the encrypted content starts
            int entireHeaderLength = headerLengthBytes.Length + iv.Length + extensionBytes.Length;
            Buffer.BlockCopy(encryptedData, iv.Length, extensionBytes, 0, extensionLength);
            

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
            string newOutputFileNoEx;
            newOutputFileNoEx = $"{Path.GetDirectoryName(newOutputFile)}\\{Path.GetFileNameWithoutExtension(newOutputFile)}";
            

            int i = 1;
            while (File.Exists(newOutputFile))
            {
                string concat = $" - ({i})";
                newOutputFile = $"{newOutputFileNoEx}{concat}";
                newOutputFile = Path.ChangeExtension(newOutputFile, extensionString);
                i++;
            }
                //renames the filestream outputfile. doesnt actually move the file
                File.Move(outputFile, newOutputFile);
        }

        private void ResetInputs()
        {
            
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.UseSystemPasswordChar = false;
            this.DeleteRadioButton.Checked = false;
            this.SelectedDirectory = null;
            this.SelectedFileName.Text = "No Selected File";
            this.DestinationDirectory = null;
            this.DestinationDirectoryLabel.Text = "No Selected Directory";
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
        private void ClearSelectedDirectory()
        {
            this.SelectedDirectory = String.Empty;
        }
        private void CheckPlaceholder(string ph)
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
        }

        public void ResetKeyInputBox()
        {
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.UseSystemPasswordChar = false;
        }

        private void DecryptUserControlTimer_Tick(object sender, EventArgs e)
        {
            this.FeedbackLabel.Text = "";
            EnableButtons();
            this.DecryptUserControlTimer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetInputs();
            this.DecryptSuccessTimer.Stop();

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
