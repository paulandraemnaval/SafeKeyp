namespace CypherWithGuna
{
    partial class SafeKeypMainpage
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
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormBar = new System.Windows.Forms.Panel();
            this.SidePanelButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptedFileLocationsButton = new System.Windows.Forms.Button();
            this.HowtouseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.PageLabel = new System.Windows.Forms.Label();
            this.ConfirmKeyPeekButton = new System.Windows.Forms.Button();
            this.KeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.PageDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ConfirmKeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.SelectedFileName = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.KeyPeekButton = new System.Windows.Forms.Button();
            this.DeleteRadioButton = new Guna.UI.WinForms.GunaCheckBox();
            this.SidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SidePanel.Controls.Add(this.SidePanelButton);
            this.SidePanel.Controls.Add(this.EncryptButton);
            this.SidePanel.Controls.Add(this.DecryptButton);
            this.SidePanel.Controls.Add(this.EncryptedFileLocationsButton);
            this.SidePanel.Controls.Add(this.HowtouseButton);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 32);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(228, 500);
            this.SidePanel.TabIndex = 29;
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLabel.Location = new System.Drawing.Point(53, 7);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(88, 22);
            this.AppLabel.TabIndex = 1;
            this.AppLabel.Text = "SafeKeyp";
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
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.White;
            this.FormBar.Controls.Add(this.MinimizeButton);
            this.FormBar.Controls.Add(this.CloseButton);
            this.FormBar.Controls.Add(this.panel2);
            this.FormBar.Controls.Add(this.AppLabel);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(813, 32);
            this.FormBar.TabIndex = 28;
            this.FormBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseDown);
            this.FormBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseMove);
            this.FormBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseUp);
            // 
            // SidePanelButton
            // 
            this.SidePanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.SidePanelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidePanelButton.Image = global::CypherWithGuna.Properties.Resources.icons8_menu_48;
            this.SidePanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SidePanelButton.Location = new System.Drawing.Point(3, 4);
            this.SidePanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanelButton.Name = "SidePanelButton";
            this.SidePanelButton.Size = new System.Drawing.Size(222, 65);
            this.SidePanelButton.TabIndex = 7;
            this.SidePanelButton.Text = "            Close Sidebar";
            this.SidePanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SidePanelButton.UseVisualStyleBackColor = false;
            this.SidePanelButton.Click += new System.EventHandler(this.SidePanelButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.EncryptButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Image = global::CypherWithGuna.Properties.Resources.icons8_security_document_48;
            this.EncryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptButton.Location = new System.Drawing.Point(3, 77);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(222, 65);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "            Encrypt";
            this.EncryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.DecryptButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.DecryptButton.Image = global::CypherWithGuna.Properties.Resources.icons8_unlock_document_48;
            this.DecryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecryptButton.Location = new System.Drawing.Point(3, 150);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(222, 65);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "            Decrypt";
            this.DecryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptedFileLocationsButton
            // 
            this.EncryptedFileLocationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.EncryptedFileLocationsButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.EncryptedFileLocationsButton.Image = global::CypherWithGuna.Properties.Resources.icons8_folder_48__3_;
            this.EncryptedFileLocationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptedFileLocationsButton.Location = new System.Drawing.Point(3, 223);
            this.EncryptedFileLocationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptedFileLocationsButton.Name = "EncryptedFileLocationsButton";
            this.EncryptedFileLocationsButton.Size = new System.Drawing.Size(222, 65);
            this.EncryptedFileLocationsButton.TabIndex = 9;
            this.EncryptedFileLocationsButton.Text = "            Encrypted File\r\n            Locations";
            this.EncryptedFileLocationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptedFileLocationsButton.UseVisualStyleBackColor = false;
            // 
            // HowtouseButton
            // 
            this.HowtouseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.HowtouseButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.HowtouseButton.Image = global::CypherWithGuna.Properties.Resources.icons8_question_mark_48__1_;
            this.HowtouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HowtouseButton.Location = new System.Drawing.Point(3, 296);
            this.HowtouseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HowtouseButton.Name = "HowtouseButton";
            this.HowtouseButton.Size = new System.Drawing.Size(222, 65);
            this.HowtouseButton.TabIndex = 8;
            this.HowtouseButton.Text = "            How To Use";
            this.HowtouseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HowtouseButton.UseVisualStyleBackColor = false;
            this.HowtouseButton.Click += new System.EventHandler(this.HowtouseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Image = global::CypherWithGuna.Properties.Resources.icons8_minimize_20;
            this.MinimizeButton.Location = new System.Drawing.Point(701, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(56, 32);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = global::CypherWithGuna.Properties.Resources.icons8_x_20;
            this.CloseButton.Location = new System.Drawing.Point(757, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 32);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = " ";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F, System.Drawing.FontStyle.Bold);
            this.PageLabel.Location = new System.Drawing.Point(238, 59);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(194, 45);
            this.PageLabel.TabIndex = 30;
            this.PageLabel.Text = "PageLabel";
            // 
            // ConfirmKeyPeekButton
            // 
            this.ConfirmKeyPeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.ConfirmKeyPeekButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.ConfirmKeyPeekButton.Location = new System.Drawing.Point(634, 249);
            this.ConfirmKeyPeekButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmKeyPeekButton.Name = "ConfirmKeyPeekButton";
            this.ConfirmKeyPeekButton.Size = new System.Drawing.Size(41, 35);
            this.ConfirmKeyPeekButton.TabIndex = 39;
            this.ConfirmKeyPeekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConfirmKeyPeekButton.UseVisualStyleBackColor = false;
            this.ConfirmKeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseDown);
            this.ConfirmKeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseUp);
            // 
            // KeyInputBox
            // 
            this.KeyInputBox.BackColor = System.Drawing.Color.White;
            this.KeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyInputBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.KeyInputBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyInputBox.LineColor = System.Drawing.Color.Gainsboro;
            this.KeyInputBox.Location = new System.Drawing.Point(245, 198);
            this.KeyInputBox.Name = "KeyInputBox";
            this.KeyInputBox.PasswordChar = '\0';
            this.KeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.KeyInputBox.TabIndex = 31;
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.TextChanged += new System.EventHandler(this.KeyInputBox_TextChanged);
            this.KeyInputBox.Enter += new System.EventHandler(this.KeyInputBox_Enter);
            this.KeyInputBox.Leave += new System.EventHandler(this.KeyInputBox_Leave);
            // 
            // PageDescriptionLabel
            // 
            this.PageDescriptionLabel.AutoSize = true;
            this.PageDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageDescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescriptionLabel.Location = new System.Drawing.Point(243, 104);
            this.PageDescriptionLabel.Name = "PageDescriptionLabel";
            this.PageDescriptionLabel.Size = new System.Drawing.Size(163, 24);
            this.PageDescriptionLabel.TabIndex = 34;
            this.PageDescriptionLabel.Text = "Page Description";
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.SelectButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectButton.Location = new System.Drawing.Point(244, 154);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(121, 35);
            this.SelectButton.TabIndex = 32;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Visible = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.ActionButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActionButton.Location = new System.Drawing.Point(372, 154);
            this.ActionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(178, 35);
            this.ActionButton.TabIndex = 33;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ConfirmKeyInputBox
            // 
            this.ConfirmKeyInputBox.BackColor = System.Drawing.Color.White;
            this.ConfirmKeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmKeyInputBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ConfirmKeyInputBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyInputBox.LineColor = System.Drawing.Color.Gainsboro;
            this.ConfirmKeyInputBox.Location = new System.Drawing.Point(245, 249);
            this.ConfirmKeyInputBox.Name = "ConfirmKeyInputBox";
            this.ConfirmKeyInputBox.PasswordChar = '\0';
            this.ConfirmKeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.ConfirmKeyInputBox.TabIndex = 35;
            this.ConfirmKeyInputBox.Text = "Confirm Key";
            this.ConfirmKeyInputBox.TextChanged += new System.EventHandler(this.ConfirmKeyInputBox_TextChanged);
            this.ConfirmKeyInputBox.Enter += new System.EventHandler(this.ConfirmKeyInputBox_Enter);
            this.ConfirmKeyInputBox.Leave += new System.EventHandler(this.ConfirmKeyInputBox_Leave);
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileName.Location = new System.Drawing.Point(241, 321);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(127, 24);
            this.SelectedFileName.TabIndex = 36;
            this.SelectedFileName.Text = "Selected File";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FeedbackLabel.Location = new System.Drawing.Point(241, 346);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(118, 30);
            this.FeedbackLabel.TabIndex = 37;
            this.FeedbackLabel.Text = "Feedback";
            // 
            // KeyPeekButton
            // 
            this.KeyPeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.KeyPeekButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.KeyPeekButton.Location = new System.Drawing.Point(634, 198);
            this.KeyPeekButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeyPeekButton.Name = "KeyPeekButton";
            this.KeyPeekButton.Size = new System.Drawing.Size(41, 35);
            this.KeyPeekButton.TabIndex = 38;
            this.KeyPeekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KeyPeekButton.UseVisualStyleBackColor = false;
            this.KeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseDown);
            this.KeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseUp);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.BaseColor = System.Drawing.Color.White;
            this.DeleteRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.DeleteRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteRadioButton.FillColor = System.Drawing.Color.White;
            this.DeleteRadioButton.Location = new System.Drawing.Point(244, 298);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(120, 20);
            this.DeleteRadioButton.TabIndex = 40;
            this.DeleteRadioButton.Text = "Delete file after ";
            // 
            // SafeKeypMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(813, 532);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.KeyPeekButton);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.SelectedFileName);
            this.Controls.Add(this.ConfirmKeyInputBox);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PageDescriptionLabel);
            this.Controls.Add(this.KeyInputBox);
            this.Controls.Add(this.ConfirmKeyPeekButton);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.FormBar);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SafeKeypMainpage";
            this.Text = "Cypher";
            this.SidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.FormBar.ResumeLayout(false);
            this.FormBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SidePanelButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptedFileLocationsButton;
        private System.Windows.Forms.Button HowtouseButton;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.Label AppLabel;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button ConfirmKeyPeekButton;
        private Guna.UI.WinForms.GunaLineTextBox KeyInputBox;
        private System.Windows.Forms.Label PageDescriptionLabel;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ActionButton;
        private Guna.UI.WinForms.GunaLineTextBox ConfirmKeyInputBox;
        private System.Windows.Forms.Label SelectedFileName;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button KeyPeekButton;
        private Guna.UI.WinForms.GunaCheckBox DeleteRadioButton;
    }
}

