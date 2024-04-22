namespace CypherWithGuna.Forms
{
    partial class DecryptUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeleteRadioButton = new Guna.UI.WinForms.GunaCheckBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.SelectedFileName = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.KeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.DecryptUserControlTimer = new System.Windows.Forms.Timer(this.components);
            this.KeyPeekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.BaseColor = System.Drawing.Color.White;
            this.DeleteRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.DeleteRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteRadioButton.FillColor = System.Drawing.Color.White;
            this.DeleteRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRadioButton.Location = new System.Drawing.Point(20, 109);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(250, 28);
            this.DeleteRadioButton.TabIndex = 58;
            this.DeleteRadioButton.Text = "Delete file after decryption";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FeedbackLabel.Location = new System.Drawing.Point(17, 165);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 30);
            this.FeedbackLabel.TabIndex = 55;
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileName.Location = new System.Drawing.Point(17, 140);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(127, 24);
            this.SelectedFileName.TabIndex = 54;
            this.SelectedFileName.Text = "Selected File";
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.ActionButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActionButton.Location = new System.Drawing.Point(148, 19);
            this.ActionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(178, 35);
            this.ActionButton.TabIndex = 52;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.SelectButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectButton.Location = new System.Drawing.Point(20, 19);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(121, 35);
            this.SelectButton.TabIndex = 51;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // KeyInputBox
            // 
            this.KeyInputBox.BackColor = System.Drawing.Color.White;
            this.KeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyInputBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.KeyInputBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyInputBox.LineColor = System.Drawing.Color.Gainsboro;
            this.KeyInputBox.Location = new System.Drawing.Point(21, 63);
            this.KeyInputBox.Name = "KeyInputBox";
            this.KeyInputBox.PasswordChar = '\0';
            this.KeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.KeyInputBox.TabIndex = 50;
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.TextChanged += new System.EventHandler(this.KeyInputBox_TextChanged);
            this.KeyInputBox.Enter += new System.EventHandler(this.KeyInputBox_Enter);
            this.KeyInputBox.Leave += new System.EventHandler(this.KeyInputBox_Leave);
            // 
            // DecryptUserControlTimer
            // 
            this.DecryptUserControlTimer.Interval = 2000;
            this.DecryptUserControlTimer.Tick += new System.EventHandler(this.DecryptUserControlTimer_Tick);
            // 
            // KeyPeekButton
            // 
            this.KeyPeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.KeyPeekButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.KeyPeekButton.Location = new System.Drawing.Point(410, 63);
            this.KeyPeekButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeyPeekButton.Name = "KeyPeekButton";
            this.KeyPeekButton.Size = new System.Drawing.Size(41, 35);
            this.KeyPeekButton.TabIndex = 56;
            this.KeyPeekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KeyPeekButton.UseVisualStyleBackColor = false;
            this.KeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseDown);
            this.KeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseUp);
            // 
            // DecryptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.KeyPeekButton);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.SelectedFileName);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.KeyInputBox);
            this.Name = "DecryptUserControl";
            this.Size = new System.Drawing.Size(464, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox DeleteRadioButton;
        private System.Windows.Forms.Button KeyPeekButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label SelectedFileName;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button SelectButton;
        private Guna.UI.WinForms.GunaLineTextBox KeyInputBox;
        private System.Windows.Forms.Timer DecryptUserControlTimer;
    }
}
