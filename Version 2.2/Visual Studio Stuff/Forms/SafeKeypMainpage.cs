using CypherWithGuna.Classes;
using CypherWithGuna.Forms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna
{
    public partial class SafeKeypMainpage : Form
    {
        //for page texts
        private int MenuState = 1;
        
        //for sidebar
        private bool SidePanelExpand = false;

        //for animation

        private string TargetWord;
        private Random random;
        private int CurrentIndex;

        //for dragging
        private bool mouseDown; //lower case because MouseDown is already defined.
        private Point LastLocation;

        public string encryptedFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "EncryptedFiles.txt");
        
        public SafeKeypMainpage()
        {
            
            InitializeComponent();
            this.PageLabel.Text = "Welcome to SafeKeyp";
            this.PageDescriptionLabel.Text = "An app that encrypts and decrypts files using the AES encryption algorithm\n" +
                "Made by Paul Andrae M. Naval";
            this.DoubleBuffered = true;
            CollapseSidebar();
            
        }




        //EVENTS
        private void SidePanelButton_Click(object sender, EventArgs e)
        {
            if (SidePanelExpand)
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
        
        
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            this.MenuState = 1;
            if (SidePanelExpand)
                CollapseSidebar();
            InitializePage();

        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            this.MenuState = 2;
            if (SidePanelExpand)
                CollapseSidebar();
            InitializePage();

        }
        private void DirectoryItem_DecryptButtonClick(object sender, EventArgs e)
        {
            this.MenuState = 2;
            if (SidePanelExpand)
                CollapseSidebar();
            InitializePage();
        }
        private void EncryptedFileLocationsButton_Click(object sender, EventArgs e)
        {
            this.MenuState = 4;
            if (SidePanelExpand)
                CollapseSidebar();
            InitializePage();
            
        }

        private void HowtouseButton_Click(object sender, EventArgs e)
        {
            if (SidePanelExpand)
                CollapseSidebar();
            this.MenuState = 3;
            InitializePage();
        }
        private void FormBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.LastLocation = e.Location;
        }
        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.LastLocation.X) + e.X, (this.Location.Y - this.LastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }


        //HELPER FUNCTIONS


        //aesthetic methods

        private void SpellPageTitle()
        {
            random = new Random();
            CurrentIndex = 0;
            this.SafeKeypMainpageTimer.Start();
        }

        //sidebar methods
        private void ExpandSidebar()
        {
            Image image;
            image = Properties.Resources.icons8_back_arrow_48;
            this.SidePanelButton.Image = image;
            this.SidePanelButton.Width = 222;
            this.SidePanel.Width = 228;
            this.EncryptButton.Width = 222;
            this.DecryptButton.Width = 222;
            this.HowtouseButton.Width = 222;
            this.EncryptedFileLocationsButton.Width = 222;
            this.EncryptedFileLocationsButton.Text = "            File Locker";
            this.EncryptButton.Text = "            Encrypt";
            this.DecryptButton.Text = "            Decrypt";
            this.HowtouseButton.Text = "            How To Use";
            this.SidePanelButton.Text = "            Close Sidebar";
            this.EncryptedFileLocationsButton.Text = "            Encrypted File\r\n            Locations\r\n";
            this.SidePanelExpand = true;


            this.PageLabel.Location = new Point(this.PageLabel.Location.X + 162, this.PageLabel.Location.Y);
            this.PageDescriptionLabel.Location = new Point(this.PageDescriptionLabel.Location.X + 162, this.PageDescriptionLabel.Location.Y);
            this.EncryptUserControl.Location = new Point(this.EncryptUserControl.Location.X + 162, this.EncryptUserControl.Location.Y);
            this.DecryptUserControl.Location = new Point(this.DecryptUserControl.Location.X + 162, this.DecryptUserControl.Location.Y);
            this.EncryptedFileLocationsUserControl.Location = new Point(this.EncryptedFileLocationsUserControl.Location.X + 162, this.EncryptedFileLocationsUserControl.Location.Y);
            this.EncryptedFileLocationsUserControl.Width = this.EncryptedFileLocationsUserControl.Width -162;
        }
        private void CollapseSidebar()
        {
            Image image;
            image = Properties.Resources.icons8_menu_48;
            this.SidePanelButton.Image = image;
            this.SidePanelButton.Width = 60;
            this.SidePanel.Width = 66;
            this.EncryptButton.Width = 60;
            this.DecryptButton.Width = 60;
            this.HowtouseButton.Width = 60;
            this.EncryptedFileLocationsButton.Width = 60;
            this.EncryptButton.Text = "";
            this.DecryptButton.Text = "";
            this.HowtouseButton.Text = "";
            this.EncryptedFileLocationsButton.Text = "";
            this.EncryptedFileLocationsButton.Text = "";
            this.SidePanelButton.Text = "";
            this.SidePanelExpand = false;

            this.PageLabel.Location = new Point(this.PageLabel.Location.X - 162, this.PageLabel.Location.Y);
            this.PageDescriptionLabel.Location = new Point(this.PageDescriptionLabel.Location.X - 162, this.PageDescriptionLabel.Location.Y);
            this.DecryptUserControl.Location = new Point(this.DecryptUserControl.Location.X - 162, this.DecryptUserControl.Location.Y);
            this.EncryptUserControl.Location = new Point(this.EncryptUserControl.Location.X - 162, this.EncryptUserControl.Location.Y);
            this.EncryptedFileLocationsUserControl.Location = new Point(this.EncryptedFileLocationsUserControl.Location.X - 162, this.EncryptedFileLocationsUserControl.Location.Y);
            this.EncryptedFileLocationsUserControl.Width = this.EncryptedFileLocationsUserControl.Width +162;
        }


        //page methods
        private void InitializePage()
        {

            if (MenuState == 1)
            {
                this.PageDescriptionLabel.Text = "Encrypt your file with a key using the AES Encryption algorithm";
                this.TargetWord = "Encrypt";
                this.PageLabel.Text = "";
                this.EncryptUserControl.Visible = true;
                this.DecryptUserControl.Visible = false;
                this.EncryptedFileLocationsUserControl.Visible = false;
                this.EncryptUserControl.ResetInputs();
                this.EncryptUserControl.HideControls();
                this.DecryptUserControl.ResetKeyInputBox();
                SpellPageTitle();
            }
            else if (MenuState == 2)
            {
                this.PageDescriptionLabel.Text = "Decrypt your file with a key using the AES Decryption algorithm";
                this.TargetWord = "Decrypt";
                this.PageLabel.Text = "";
                this.EncryptUserControl.Visible = false;
                this.DecryptUserControl.Visible = true;
                this.EncryptedFileLocationsUserControl.Visible = false;
                this.EncryptUserControl.ResetInputs();
                this.EncryptUserControl.HideControls();
                this.DecryptUserControl.ResetKeyInputBox();
                SpellPageTitle();
            }
            else if (MenuState == 3)
            {
                this.PageLabel.Text = "";
                this.TargetWord = "How to use";
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
                this.EncryptUserControl.Visible = false;
                this.DecryptUserControl.Visible = false;
                this.EncryptedFileLocationsUserControl.Visible = false;
                this.EncryptUserControl.ResetInputs();
                this.EncryptUserControl.HideControls();
                this.DecryptUserControl.ResetKeyInputBox();
                SpellPageTitle();
            }
            else if (MenuState == 4)
            {
                this.PageLabel.Text = "";
                this.TargetWord = "Encrypted File Recovery";
                this.PageDescriptionLabel.Text = "Recover Encrypted Files";
                this.EncryptUserControl.Visible = false;
                this.DecryptUserControl.Visible = false;
                this.EncryptedFileLocationsUserControl.Visible = true;
                SpellPageTitle();
                this.EncryptedFileLocationsUserControl.populateDirectories();//now named as DirectoriesDisplay
                this.EncryptUserControl.ResetInputs();
                this.EncryptUserControl.HideControls();
                this.DecryptUserControl.ResetKeyInputBox();
                
            }
            

        }
       
        private void SafeKeypMainpageTimer_Tick(object sender, EventArgs e)
        {
            char[] SpelledOut = new char[this.TargetWord.Length];
            char[] PossibleCharacters = "!@#$%^&*()_+-=<>?/.,;:[]{}|1234567890".ToCharArray();
            
            if(CurrentIndex < this.TargetWord.Length)
            {
                for(int i = 0; i < this.TargetWord.Length; i++)
                    SpelledOut[i] = i <= CurrentIndex ? this.TargetWord[i] : PossibleCharacters[random.Next(0, PossibleCharacters.Length)];
                CurrentIndex++;
                this.PageLabel.Text = new string(SpelledOut);
            }
            else
            {
                this.SafeKeypMainpageTimer.Stop();
                this.PageLabel.Text = this.TargetWord;
                return;
            }
        }
    }
}
