using CypherWithGuna.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CypherWithGuna.Forms
{
    public partial class RecoverKeyForm : Form
    {
        private string StoredPath;
        public RecoverKeyForm(string StoredPath)
        {
            InitializeComponent();
            this.StoredPath = StoredPath;
        }

        private void SetSecurityQuestionButton_Click(object sender, EventArgs e)
        {
            DocumentReference fileRecoveryInformation = FireBaseHelper.db.Document("FileRecoveryInformation/" + StoredPath);
            FileRecoveryInformation info = fileRecoveryInformation.GetSnapshotAsync().Result.ConvertTo<FileRecoveryInformation>();
            
            string actualanswer = info.DecryptAnswer();
            string QuestionNo = this.SecurityQuestionComboBox.SelectedItem.ToString().Split('.')[0];
            string InputtedAnswer = this.SecurityQuestionAnswerTextBox.Text;

            MessageBox.Show($"encrypted key:{info.Key}");
            
            if (this.SecurityQuestionComboBox.SelectedItem == null)
            {
                this.UploadResultLabel.Text = "Please select a security question";
                this.UploadResultLabel.ForeColor = Color.Red;
                return;
            }
            if (this.SecurityQuestionAnswerTextBox.Text == "")
            {
                this.UploadResultLabel.Text = "Please enter a security question answer";
                this.UploadResultLabel.ForeColor = Color.Red;
                return;
            }
            if(Convert.ToInt32(QuestionNo) != info.QuestionNo || InputtedAnswer != actualanswer)
            {
                MessageBox.Show("decrypted answer from the database:" + actualanswer + "\nanswer inputted: " + InputtedAnswer);
                this.UploadResultLabel.Text = "Incorrect security question or security question answer";
                this.UploadResultLabel.ForeColor = Color.Red;
                return;
            }
            this.UploadResultLabel.Text = $"Key used to encrypt file: {info.DecryptKey()}";

        }

        private void CancelSetupButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RecoveryDecypt()
        {

        }
    }
}
