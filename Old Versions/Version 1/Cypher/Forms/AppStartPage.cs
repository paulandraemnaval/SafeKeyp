using System.Collections.Generic;
using Cypher.Classes;
using Google.Cloud.Firestore;
using System;
using Cypher.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using static Google.Api.ResourceDescriptor.Types;
using System.Security.Principal;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace Cypher
{


    public partial class AppStartPage : Form
    {
        private Boolean isLogin;
        public string currentAccount_Username;
        public AppStartPage()
        {
            checkUsers();
            InitializeComponent();
            this.UsernameBox.Enter += UsernameBox_Enter;
            this.UsernameBox.Leave += UsernameBox_Leave;
            this.PasswordBox.Enter += PasswordBox_Enter;
            this.PasswordBox.Leave += PasswordBox_Leave;
            this.LoginButton.Click += LoginButton_Click;
            this.SigninButton.Click += SigninButton_Click;
            this.MainButton.MouseEnter += MainButton_MouseEnter;
            this.MainButton.MouseLeave += MainButton_MouseLeave;
            this.MainButton.Click += MainButton_Click;

            this.isLogin = true;
            this.ActiveControl = null;
            this.ResultLabel.Text = "";
            LoginButton.Font = new Font("Bahnschrift Light Condensed", 15, FontStyle.Underline);
            LoginButton.ForeColor = Color.FromArgb(179, 190, 209);


        }


        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            UsernameBox.UnderlinedStyle = true;
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            UsernameBox.UnderlinedStyle = false;
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            PasswordBox.UnderlinedStyle = true;
            PasswordBox.isPassword = true;
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            PasswordBox.UnderlinedStyle = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Font = new Font("Bahnschrift Light Condensed", 15, FontStyle.Underline);
            LoginButton.ForeColor = Color.FromArgb(179, 190, 209);
            SigninButton.Font = new Font("Bahnschrift Light Condensed", 15, FontStyle.Regular);
            SigninButton.ForeColor = Color.FromArgb(0, 0, 0);
            MainButton.Text = "Login";
            isLogin = true;
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            SigninButton.Font = new Font("Bahnschrift Light Condensed", 15, FontStyle.Underline);
            SigninButton.ForeColor = Color.FromArgb(179, 190, 209);
            LoginButton.Font = new Font("Bahnschrift Light Condensed", 15, FontStyle.Regular);
            LoginButton.ForeColor = Color.FromArgb(0, 0, 0);
            MainButton.Text = "Sign Up";
            isLogin = false;
        }

        private void MainButton_MouseEnter(object sender, EventArgs e)
        {
            MainButton.ForeColor = Color.FromArgb(46, 54, 77);
            MainButton.BackColor = Color.FromArgb(179, 190, 209);
        }

        private void MainButton_MouseLeave(object sender, EventArgs e)
        {
            MainButton.ForeColor = Color.FromArgb(0, 0, 0);
            MainButton.BackColor = Color.FromArgb(158, 158, 158);
        }


        private async void MainButton_Click(object sender, EventArgs e)
        {

            this.MainButton.Enabled = false;
            if (UsernameBox.Text.Trim() == "Username" || PasswordBox.Text.Trim() == "Password")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            else if (isLogin)
            {
                // Login
                string username = UsernameBox.Text.Trim();
                string password = PasswordBox.Text;
                var db = FirebaseHelper.db;

                DocumentReference docref = db.Collection("Accounts").Document(username);
                Account account = docref.GetSnapshotAsync().Result.ConvertTo<Account>();




                if (account != null)
                {
                    if (account.VerifyPassword(password))
                    {

                        ResultLabel.Text = "Login Successful";
                        await Task.Delay(1000);
                        ResultLabel.Text = "Loading Main Menu...";
                        await Task.Delay(1000);
                        ResultLabel.Text = "";

                        MainPage mainMenu = new MainPage(account);
                        this.currentAccount_Username = account.Username;

                        this.Hide();
                        this.MainButton.Enabled = true;
                        this.PasswordBox.Text = "Password";
                        mainMenu.Show();
                        this.PasswordBox.isPassword = false;
                        if (!this.RememberUsername.Checked)
                            this.UsernameBox.Text = "Username";
                        return;

                    }
                    else
                    {
                        this.MainButton.Enabled = true;
                        ResultLabel.Text = "Invalid username or password";
                        await Task.Delay(1000);
                        ResultLabel.Text = "";
                        return;
                    }
                }
                else
                {
                    this.MainButton.Enabled = true;
                    ResultLabel.Text = "Invalid username or password";
                    await Task.Delay(1000);
                    ResultLabel.Text = "";
                    return;
                }

            }
            else if (!isLogin)
            {
                //Signup
                var db = FirebaseHelper.db;
                if (checkIfUserAlreadyExists())
                {
                    ResultLabel.Text = "Username already exists";
                    await Task.Delay(1000);
                    ResultLabel.Text = "";
                    this.MainButton.Enabled = true;
                    return;
                }
                
                var account = getAccountData();
                DocumentReference docref = db.Collection("Accounts").Document(account.Username);
                await docref.SetAsync(account);
                string directory = "C:\\Users\\Public\\Documents\\Cypher\\FileSafe\\";
                Directory.CreateDirectory(directory);
                File.Create(directory + account.Username + ".fs").Close();
                ResultLabel.Text = "Account created";
                await Task.Delay(1000);
                ResultLabel.Text = "";
                this.MainButton.Enabled = true;

            }
        }

        public bool checkIfUserAlreadyExists()
        {
            string username = UsernameBox.Text.Trim();

            var db = FirebaseHelper.db;

            DocumentReference docref = db.Collection("Accounts").Document(username);
            Account account = docref.GetSnapshotAsync().Result.ConvertTo<Account>();
            if (account == null)
                return false;
            return true;
        }
        private Account getAccountData()
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            return new Account(username, password);
        }
        
        private void checkUsers()
        {
            var db = FirebaseHelper.db;
            var collection = db.Collection("Accounts");
            var query = collection.GetSnapshotAsync().Result;
            string path = "C:\\Users\\Public\\Documents\\Cypher\\FileSafe";
            string[] files = Directory.GetFiles(path);

            bool found = false;

            foreach (string filename in files)
            {
                found = false;
                foreach(DocumentSnapshot document in query.Documents)
                {
                    Account account = document.ConvertTo<Account>();

                    if (filename.Contains(account.Username))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    File.Delete(filename);
            }
        }

        
    }

}
