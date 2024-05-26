namespace CypherWithGuna.Forms
{
    partial class RecoverKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.AppLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecoverFileButton = new System.Windows.Forms.Button();
            this.SecurityQuestionAnswerTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.SelectedFileName = new System.Windows.Forms.Label();
            this.SecurityQuestionComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.UploadResultLabel = new System.Windows.Forms.Label();
            this.CancelSetupButton = new System.Windows.Forms.Button();
            this.DeleteRadioButton = new Guna.UI.WinForms.GunaCheckBox();
            this.FormBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.White;
            this.FormBar.Controls.Add(this.panel2);
            this.FormBar.Controls.Add(this.AppLabel);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(442, 32);
            this.FormBar.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 32);
            this.panel2.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CypherWithGuna.Properties.Resources.icons8_binary_file_50;
            this.gunaPictureBox1.Location = new System.Drawing.Point(11, 6);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(21, 21);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLabel.Location = new System.Drawing.Point(53, 6);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(88, 22);
            this.AppLabel.TabIndex = 1;
            this.AppLabel.Text = "SafeKeyp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 61;
            this.label1.Text = "Recover File";
            // 
            // RecoverFileButton
            // 
            this.RecoverFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.RecoverFileButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecoverFileButton.Location = new System.Drawing.Point(12, 259);
            this.RecoverFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecoverFileButton.Name = "RecoverFileButton";
            this.RecoverFileButton.Size = new System.Drawing.Size(203, 35);
            this.RecoverFileButton.TabIndex = 60;
            this.RecoverFileButton.Text = "Recover File";
            this.RecoverFileButton.UseVisualStyleBackColor = false;
            this.RecoverFileButton.Click += new System.EventHandler(this.SetSecurityQuestionButton_Click);
            // 
            // SecurityQuestionAnswerTextBox
            // 
            this.SecurityQuestionAnswerTextBox.BackColor = System.Drawing.Color.White;
            this.SecurityQuestionAnswerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecurityQuestionAnswerTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SecurityQuestionAnswerTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.SecurityQuestionAnswerTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.SecurityQuestionAnswerTextBox.Location = new System.Drawing.Point(12, 190);
            this.SecurityQuestionAnswerTextBox.Name = "SecurityQuestionAnswerTextBox";
            this.SecurityQuestionAnswerTextBox.PasswordChar = '\0';
            this.SecurityQuestionAnswerTextBox.Size = new System.Drawing.Size(383, 35);
            this.SecurityQuestionAnswerTextBox.TabIndex = 59;
            this.SecurityQuestionAnswerTextBox.Text = "Answer";
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileName.Location = new System.Drawing.Point(9, 108);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(169, 24);
            this.SelectedFileName.TabIndex = 58;
            this.SelectedFileName.Text = "Security Question";
            // 
            // SecurityQuestionComboBox
            // 
            this.SecurityQuestionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SecurityQuestionComboBox.BaseColor = System.Drawing.Color.White;
            this.SecurityQuestionComboBox.BorderColor = System.Drawing.Color.Silver;
            this.SecurityQuestionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SecurityQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityQuestionComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SecurityQuestionComboBox.ForeColor = System.Drawing.Color.Black;
            this.SecurityQuestionComboBox.FormattingEnabled = true;
            this.SecurityQuestionComboBox.Items.AddRange(new object[] {
            "Select security question",
            "1.What is your father\'s name"});
            this.SecurityQuestionComboBox.Location = new System.Drawing.Point(12, 137);
            this.SecurityQuestionComboBox.Name = "SecurityQuestionComboBox";
            this.SecurityQuestionComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SecurityQuestionComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SecurityQuestionComboBox.Size = new System.Drawing.Size(383, 31);
            this.SecurityQuestionComboBox.TabIndex = 57;
            // 
            // UploadResultLabel
            // 
            this.UploadResultLabel.AutoSize = true;
            this.UploadResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.UploadResultLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadResultLabel.Location = new System.Drawing.Point(12, 304);
            this.UploadResultLabel.Name = "UploadResultLabel";
            this.UploadResultLabel.Size = new System.Drawing.Size(181, 28);
            this.UploadResultLabel.TabIndex = 64;
            this.UploadResultLabel.Text = "Recovery Result";
            // 
            // CancelSetupButton
            // 
            this.CancelSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelSetupButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSetupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelSetupButton.Location = new System.Drawing.Point(304, 371);
            this.CancelSetupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelSetupButton.Name = "CancelSetupButton";
            this.CancelSetupButton.Size = new System.Drawing.Size(126, 35);
            this.CancelSetupButton.TabIndex = 63;
            this.CancelSetupButton.Text = "Cancel";
            this.CancelSetupButton.UseVisualStyleBackColor = false;
            this.CancelSetupButton.Click += new System.EventHandler(this.CancelSetupButton_Click);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.BaseColor = System.Drawing.Color.White;
            this.DeleteRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.DeleteRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteRadioButton.FillColor = System.Drawing.Color.White;
            this.DeleteRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRadioButton.Location = new System.Drawing.Point(12, 229);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(324, 28);
            this.DeleteRadioButton.TabIndex = 65;
            this.DeleteRadioButton.Text = "Delete encrypted file upon recovery";
            // 
            // RecoverKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 413);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.FormBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecoverFileButton);
            this.Controls.Add(this.SecurityQuestionAnswerTextBox);
            this.Controls.Add(this.SelectedFileName);
            this.Controls.Add(this.SecurityQuestionComboBox);
            this.Controls.Add(this.UploadResultLabel);
            this.Controls.Add(this.CancelSetupButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverKeyForm";
            this.Text = "RecoverKeyForm";
            this.FormBar.ResumeLayout(false);
            this.FormBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecoverFileButton;
        private Guna.UI.WinForms.GunaLineTextBox SecurityQuestionAnswerTextBox;
        private System.Windows.Forms.Label SelectedFileName;
        private Guna.UI.WinForms.GunaComboBox SecurityQuestionComboBox;
        private System.Windows.Forms.Label UploadResultLabel;
        private System.Windows.Forms.Button CancelSetupButton;
        private Guna.UI.WinForms.GunaCheckBox DeleteRadioButton;
    }
}