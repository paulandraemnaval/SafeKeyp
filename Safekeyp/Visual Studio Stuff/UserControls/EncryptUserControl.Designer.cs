namespace CypherWithGuna.Forms
{
    partial class EncryptUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptUserControl));
            this.EncryptUserControlTimer = new System.Windows.Forms.Timer(this.components);
            this.EncryptSuccessTimer = new System.Windows.Forms.Timer(this.components);
            this.SelectedFileName = new System.Windows.Forms.Label();
            this.DeleteRadioButton = new Guna.UI.WinForms.GunaCheckBox();
            this.DestinationDirectoryLabel = new System.Windows.Forms.Label();
            this.KeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.ConfirmKeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.ActionButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SelectDestinationButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ConfirmKeyPeekButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.KeyPeekButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SelectFileButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptUserControlTimer
            // 
            this.EncryptUserControlTimer.Interval = 1000;
            this.EncryptUserControlTimer.Tick += new System.EventHandler(this.EncryptUserControlTimer_Tick);
            // 
            // EncryptSuccessTimer
            // 
            this.EncryptSuccessTimer.Interval = 1000;
            this.EncryptSuccessTimer.Tick += new System.EventHandler(this.EncryptSuccessTimer_Tick);
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileName.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileName.ForeColor = System.Drawing.Color.Lime;
            this.SelectedFileName.Location = new System.Drawing.Point(185, 62);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(153, 20);
            this.SelectedFileName.TabIndex = 45;
            this.SelectedFileName.Text = "No selected File";
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.BackColor = System.Drawing.Color.Lime;
            this.DeleteRadioButton.BaseColor = System.Drawing.Color.Black;
            this.DeleteRadioButton.CheckedOffColor = System.Drawing.Color.Black;
            this.DeleteRadioButton.CheckedOnColor = System.Drawing.Color.Red;
            this.DeleteRadioButton.FillColor = System.Drawing.Color.Red;
            this.DeleteRadioButton.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRadioButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteRadioButton.Location = new System.Drawing.Point(20, 383);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(411, 24);
            this.DeleteRadioButton.TabIndex = 4;
            this.DeleteRadioButton.Text = "Delete original file after encryption ";
            // 
            // DestinationDirectoryLabel
            // 
            this.DestinationDirectoryLabel.AutoSize = true;
            this.DestinationDirectoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.DestinationDirectoryLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.DestinationDirectoryLabel.ForeColor = System.Drawing.Color.Lime;
            this.DestinationDirectoryLabel.Location = new System.Drawing.Point(18, 269);
            this.DestinationDirectoryLabel.Name = "DestinationDirectoryLabel";
            this.DestinationDirectoryLabel.Size = new System.Drawing.Size(198, 20);
            this.DestinationDirectoryLabel.TabIndex = 52;
            this.DestinationDirectoryLabel.Text = "No Selected Directory";
            // 
            // KeyInputBox
            // 
            this.KeyInputBox.BackColor = System.Drawing.Color.Black;
            this.KeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyInputBox.FocusedLineColor = System.Drawing.Color.Lime;
            this.KeyInputBox.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyInputBox.ForeColor = System.Drawing.Color.Lime;
            this.KeyInputBox.LineColor = System.Drawing.Color.Lime;
            this.KeyInputBox.Location = new System.Drawing.Point(22, 102);
            this.KeyInputBox.Name = "KeyInputBox";
            this.KeyInputBox.PasswordChar = '\0';
            this.KeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.KeyInputBox.TabIndex = 53;
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.TextChanged += new System.EventHandler(this.KeyInputBox_TextChanged);
            this.KeyInputBox.Enter += new System.EventHandler(this.KeyInputBox_Enter);
            this.KeyInputBox.Leave += new System.EventHandler(this.KeyInputBox_Leave);
            // 
            // ConfirmKeyInputBox
            // 
            this.ConfirmKeyInputBox.BackColor = System.Drawing.Color.Black;
            this.ConfirmKeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmKeyInputBox.FocusedLineColor = System.Drawing.Color.Lime;
            this.ConfirmKeyInputBox.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyInputBox.ForeColor = System.Drawing.Color.Lime;
            this.ConfirmKeyInputBox.LineColor = System.Drawing.Color.Lime;
            this.ConfirmKeyInputBox.Location = new System.Drawing.Point(22, 153);
            this.ConfirmKeyInputBox.Name = "ConfirmKeyInputBox";
            this.ConfirmKeyInputBox.PasswordChar = '\0';
            this.ConfirmKeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.ConfirmKeyInputBox.TabIndex = 56;
            this.ConfirmKeyInputBox.Text = "Confirm Key";
            this.ConfirmKeyInputBox.TextChanged += new System.EventHandler(this.ConfirmKeyInputBox_TextChanged);
            this.ConfirmKeyInputBox.Enter += new System.EventHandler(this.ConfirmKeyInputBox_Enter);
            this.ConfirmKeyInputBox.Leave += new System.EventHandler(this.ConfirmKeyInputBox_Leave);
            // 
            // ActionButton
            // 
            this.ActionButton.AnimationHoverSpeed = 0.07F;
            this.ActionButton.AnimationSpeed = 0.03F;
            this.ActionButton.BaseColor = System.Drawing.Color.Black;
            this.ActionButton.BorderColor = System.Drawing.Color.Lime;
            this.ActionButton.BorderSize = 1;
            this.ActionButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ActionButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ActionButton.CheckedForeColor = System.Drawing.Color.White;
            this.ActionButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ActionButton.CheckedImage")));
            this.ActionButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ActionButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.ForeColor = System.Drawing.Color.Lime;
            this.ActionButton.Image = null;
            this.ActionButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ActionButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ActionButton.Location = new System.Drawing.Point(20, 346);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.ActionButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.ActionButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ActionButton.OnHoverImage = null;
            this.ActionButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.ActionButton.OnPressedColor = System.Drawing.Color.Black;
            this.ActionButton.Size = new System.Drawing.Size(160, 31);
            this.ActionButton.TabIndex = 59;
            this.ActionButton.Text = "Encrypt File";
            this.ActionButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // SelectDestinationButton
            // 
            this.SelectDestinationButton.AnimationHoverSpeed = 0.07F;
            this.SelectDestinationButton.AnimationSpeed = 0.03F;
            this.SelectDestinationButton.BaseColor = System.Drawing.Color.Black;
            this.SelectDestinationButton.BorderColor = System.Drawing.Color.Lime;
            this.SelectDestinationButton.BorderSize = 1;
            this.SelectDestinationButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SelectDestinationButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SelectDestinationButton.CheckedForeColor = System.Drawing.Color.White;
            this.SelectDestinationButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SelectDestinationButton.CheckedImage")));
            this.SelectDestinationButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SelectDestinationButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDestinationButton.ForeColor = System.Drawing.Color.Lime;
            this.SelectDestinationButton.Image = null;
            this.SelectDestinationButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SelectDestinationButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SelectDestinationButton.Location = new System.Drawing.Point(20, 217);
            this.SelectDestinationButton.Name = "SelectDestinationButton";
            this.SelectDestinationButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.SelectDestinationButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.SelectDestinationButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.SelectDestinationButton.OnHoverImage = null;
            this.SelectDestinationButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.SelectDestinationButton.OnPressedColor = System.Drawing.Color.Black;
            this.SelectDestinationButton.Size = new System.Drawing.Size(243, 49);
            this.SelectDestinationButton.TabIndex = 58;
            this.SelectDestinationButton.Text = "Select File Destination";
            this.SelectDestinationButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectDestinationButton.Click += new System.EventHandler(this.SelectDestinationButton_Click);
            // 
            // ConfirmKeyPeekButton
            // 
            this.ConfirmKeyPeekButton.AnimationHoverSpeed = 0.07F;
            this.ConfirmKeyPeekButton.AnimationSpeed = 0.03F;
            this.ConfirmKeyPeekButton.BaseColor = System.Drawing.Color.Lime;
            this.ConfirmKeyPeekButton.BorderColor = System.Drawing.Color.Lime;
            this.ConfirmKeyPeekButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ConfirmKeyPeekButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ConfirmKeyPeekButton.CheckedForeColor = System.Drawing.Color.White;
            this.ConfirmKeyPeekButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ConfirmKeyPeekButton.CheckedImage")));
            this.ConfirmKeyPeekButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ConfirmKeyPeekButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyPeekButton.ForeColor = System.Drawing.Color.Lime;
            this.ConfirmKeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.ConfirmKeyPeekButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmKeyPeekButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ConfirmKeyPeekButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ConfirmKeyPeekButton.Location = new System.Drawing.Point(413, 153);
            this.ConfirmKeyPeekButton.Name = "ConfirmKeyPeekButton";
            this.ConfirmKeyPeekButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.ConfirmKeyPeekButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.ConfirmKeyPeekButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ConfirmKeyPeekButton.OnHoverImage = null;
            this.ConfirmKeyPeekButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.ConfirmKeyPeekButton.OnPressedColor = System.Drawing.Color.Black;
            this.ConfirmKeyPeekButton.Size = new System.Drawing.Size(45, 35);
            this.ConfirmKeyPeekButton.TabIndex = 57;
            this.ConfirmKeyPeekButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmKeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseDown);
            this.ConfirmKeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseUp);
            // 
            // KeyPeekButton
            // 
            this.KeyPeekButton.AnimationHoverSpeed = 0.07F;
            this.KeyPeekButton.AnimationSpeed = 0.03F;
            this.KeyPeekButton.BaseColor = System.Drawing.Color.Lime;
            this.KeyPeekButton.BorderColor = System.Drawing.Color.Lime;
            this.KeyPeekButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.KeyPeekButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.KeyPeekButton.CheckedForeColor = System.Drawing.Color.White;
            this.KeyPeekButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("KeyPeekButton.CheckedImage")));
            this.KeyPeekButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.KeyPeekButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPeekButton.ForeColor = System.Drawing.Color.Lime;
            this.KeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.KeyPeekButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyPeekButton.ImageSize = new System.Drawing.Size(25, 25);
            this.KeyPeekButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.KeyPeekButton.Location = new System.Drawing.Point(413, 102);
            this.KeyPeekButton.Name = "KeyPeekButton";
            this.KeyPeekButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.KeyPeekButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.KeyPeekButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.KeyPeekButton.OnHoverImage = null;
            this.KeyPeekButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.KeyPeekButton.OnPressedColor = System.Drawing.Color.Black;
            this.KeyPeekButton.Size = new System.Drawing.Size(45, 35);
            this.KeyPeekButton.TabIndex = 55;
            this.KeyPeekButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseDown);
            this.KeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseUp);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.AnimationHoverSpeed = 0.07F;
            this.SelectFileButton.AnimationSpeed = 0.03F;
            this.SelectFileButton.BaseColor = System.Drawing.Color.Lime;
            this.SelectFileButton.BorderColor = System.Drawing.Color.Black;
            this.SelectFileButton.BorderSize = 1;
            this.SelectFileButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SelectFileButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SelectFileButton.CheckedForeColor = System.Drawing.Color.White;
            this.SelectFileButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SelectFileButton.CheckedImage")));
            this.SelectFileButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SelectFileButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileButton.ForeColor = System.Drawing.Color.Black;
            this.SelectFileButton.Image = null;
            this.SelectFileButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SelectFileButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SelectFileButton.Location = new System.Drawing.Point(19, 26);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.SelectFileButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.SelectFileButton.OnHoverForeColor = System.Drawing.Color.Lime;
            this.SelectFileButton.OnHoverImage = null;
            this.SelectFileButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.SelectFileButton.OnPressedColor = System.Drawing.Color.Black;
            this.SelectFileButton.Size = new System.Drawing.Size(160, 56);
            this.SelectFileButton.TabIndex = 54;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackLabel.ForeColor = System.Drawing.Color.Lime;
            this.FeedbackLabel.Location = new System.Drawing.Point(23, 306);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 27);
            this.FeedbackLabel.TabIndex = 60;
            // 
            // EncryptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.SelectDestinationButton);
            this.Controls.Add(this.ConfirmKeyPeekButton);
            this.Controls.Add(this.ConfirmKeyInputBox);
            this.Controls.Add(this.KeyPeekButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.KeyInputBox);
            this.Controls.Add(this.DestinationDirectoryLabel);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.SelectedFileName);
            this.Name = "EncryptUserControl";
            this.Size = new System.Drawing.Size(479, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer EncryptUserControlTimer;
        private System.Windows.Forms.Timer EncryptSuccessTimer;
        private System.Windows.Forms.Label SelectedFileName;
        private Guna.UI.WinForms.GunaCheckBox DeleteRadioButton;
        private System.Windows.Forms.Label DestinationDirectoryLabel;
        private Guna.UI.WinForms.GunaLineTextBox KeyInputBox;
        private Guna.UI.WinForms.GunaAdvenceButton SelectFileButton;
        private Guna.UI.WinForms.GunaAdvenceButton KeyPeekButton;
        private Guna.UI.WinForms.GunaLineTextBox ConfirmKeyInputBox;
        private Guna.UI.WinForms.GunaAdvenceButton ConfirmKeyPeekButton;
        private Guna.UI.WinForms.GunaAdvenceButton SelectDestinationButton;
        private Guna.UI.WinForms.GunaAdvenceButton ActionButton;
        private System.Windows.Forms.Label FeedbackLabel;
    }
}
