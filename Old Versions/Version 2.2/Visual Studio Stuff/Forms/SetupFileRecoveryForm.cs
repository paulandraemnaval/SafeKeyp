using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CypherWithGuna.Classes;
using Google.Cloud.Firestore;

namespace CypherWithGuna.Forms
{
    public partial class SetupFileRecoveryForm : Form
    {
        public bool Result;
        private Point LastLocation;
        private Point eucLocation;
        private bool mouseDown;
        private int eucWidth;
        private int eucHeight;
        private string FilePath;
        private string seed;
        public SetupFileRecoveryForm(EncryptUserControl euc)
        {
            InitializeComponent();
            this.eucLocation = euc.Location;
            this.eucWidth = euc.Width;
            this.eucHeight = euc.Height;
            this.FilePath = euc.SelectedDirectory;
            this.DoubleBuffered = true;
            this.seed = euc.seed;

        }

        private void FormBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.LastLocation = e.Location;
        }

        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
                this.Location = new Point((this.Location.X - this.LastLocation.X) + e.X, (this.Location.Y - this.LastLocation.Y) + e.Y);
            this.Update();
        }

        private void SetSecurityQuestionButton_Click(object sender, EventArgs e)
        {
            if(this.SecurityQuestionComboBox.SelectedItem == null)
            {
                this.UploadResultLabel.Text = "Please select a security question";
                this.UploadResultLabel.ForeColor = Color.Red;
                return;
            }
            if(this.SecurityQuestionAnswerTextBox.Text == "")
            {
                this.UploadResultLabel.Text = "Please enter an answer";
                this.UploadResultLabel.ForeColor = Color.Red;
                return;
            }
            if (CheckIfFileExistsInDB())
            {
                //make user controls that asks for confirmation
                OverwriteRecoveryInformationDialog dialog = new OverwriteRecoveryInformationDialog(this.Location, this.Width, this.Height);
                dialog.ShowDialog();
                if (dialog.result)
                {
                    UploadData();
                    UploadSuccess();
                    dialog.Close();
                }
                else
                {
                    dialog.Close();
                    return;
                }
            }
            else
            {
                UploadData();
                UploadSuccess();
            }
        }
        private bool CheckIfFileExistsInDB()
        {
            DocumentReference check = FireBaseHelper.db.Collection("FileRecoveryInformation").Document(this.FilePath);
            FileRecoveryInformation fri = check.GetSnapshotAsync().Result.ConvertTo<FileRecoveryInformation>();
            if (fri == null)
            {
                return false;
            }
            return true;
        }

        private async void UploadData()
        {
            string QuestionNumber = this.SecurityQuestionComboBox.SelectedItem.ToString().Split('.')[0];
            
            DocumentSnapshot countsnap = await FireBaseHelper.db.Collection("Incrementor").Document("IncrementorDocument").GetSnapshotAsync();
            countsnap.ToDictionary();
            var count = countsnap.GetValue<int>("IncrementCount");

            var fri = new FileRecoveryInformation(this.FilePath, Convert.ToInt32(QuestionNumber), this.SecurityQuestionAnswerTextBox.Text, count, seed);
            var db = FireBaseHelper.db;

            DocumentSnapshot docrefsnap = await db.Collection("Incrementor").Document("IncrementorDocument").GetSnapshotAsync();
            docrefsnap.ToDictionary();
            
            DocumentReference incrementorreference = db.Collection("Incrementor").Document("IncrementorDocument");
            await incrementorreference.SetAsync(new { IncrementCount = count + 1 });

            DocumentReference docref = db.Collection("FileRecoveryInformation").Document(fri.FilePath);
            await docref.SetAsync(fri);

            
        }

        private async void UploadSuccess()
        {
            this.UploadResultLabel.Text = "Upload Successful";
            this.UploadResultLabel.ForeColor = Color.Green;
            await Task.Delay(1000);
            this.Result = true;
            this.Hide();

        }

       
        private void CancelSetupButton_Click(object sender, EventArgs e)
        {
            this.Result = false;
            this.Close();
            this.Hide();
        }

        public void ShowSetupFileRecoveryForm()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(eucLocation.X + ( this.eucWidth - this.Width) / 2, this.eucLocation.Y + (this.eucHeight - this.Height) / 2);
            this.ShowDialog();
        }

    }
}
