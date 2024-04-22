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
            this.components = new System.ComponentModel.Container();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SidePanelButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptedFileLocationsButton = new System.Windows.Forms.Button();
            this.HowtouseButton = new System.Windows.Forms.Button();
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.FormBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PageDescriptionLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.SafeKeypMainpageTimer = new System.Windows.Forms.Timer(this.components);
            this.EncryptedFileLocationsUserControl = new CypherWithGuna.Forms.DirectoriesDisplay();
            this.DecryptUserControl = new CypherWithGuna.Forms.DecryptUserControl();
            this.EncryptUserControl = new CypherWithGuna.Forms.EncryptUserControl();
            this.SidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.FormBar.SuspendLayout();
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
            this.EncryptedFileLocationsButton.Click += new System.EventHandler(this.EncryptedFileLocationsButton_Click);
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
            // PageDescriptionLabel
            // 
            this.PageDescriptionLabel.AutoSize = true;
            this.PageDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageDescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescriptionLabel.Location = new System.Drawing.Point(252, 102);
            this.PageDescriptionLabel.Name = "PageDescriptionLabel";
            this.PageDescriptionLabel.Size = new System.Drawing.Size(163, 24);
            this.PageDescriptionLabel.TabIndex = 38;
            this.PageDescriptionLabel.Text = "Page Description";
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F, System.Drawing.FontStyle.Bold);
            this.PageLabel.Location = new System.Drawing.Point(248, 57);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(194, 45);
            this.PageLabel.TabIndex = 37;
            this.PageLabel.Text = "PageLabel";
            // 
            // SafeKeypMainpageTimer
            // 
            this.SafeKeypMainpageTimer.Tick += new System.EventHandler(this.SafeKeypMainpageTimer_Tick);
            // 
            // EncryptedFileLocationsUserControl
            // 
            this.EncryptedFileLocationsUserControl.AutoScroll = true;
            this.EncryptedFileLocationsUserControl.BackColor = System.Drawing.Color.Transparent;
            this.EncryptedFileLocationsUserControl.Location = new System.Drawing.Point(247, 131);
            this.EncryptedFileLocationsUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EncryptedFileLocationsUserControl.Name = "EncryptedFileLocationsUserControl";
            this.EncryptedFileLocationsUserControl.parentform = null;
            this.EncryptedFileLocationsUserControl.Size = new System.Drawing.Size(638, 483);
            this.EncryptedFileLocationsUserControl.TabIndex = 41;
            this.EncryptedFileLocationsUserControl.Visible = false;
            // 
            // DecryptUserControl
            // 
            this.DecryptUserControl.BackColor = System.Drawing.Color.Transparent;
            this.DecryptUserControl.Location = new System.Drawing.Point(234, 131);
            this.DecryptUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DecryptUserControl.Name = "DecryptUserControl";
            this.DecryptUserControl.Size = new System.Drawing.Size(638, 346);
            this.DecryptUserControl.TabIndex = 40;
            this.DecryptUserControl.Visible = false;
            // 
            // EncryptUserControl
            // 
            this.EncryptUserControl.BackColor = System.Drawing.Color.Transparent;
            this.EncryptUserControl.Location = new System.Drawing.Point(234, 131);
            this.EncryptUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EncryptUserControl.Name = "EncryptUserControl";
            this.EncryptUserControl.Size = new System.Drawing.Size(638, 483);
            this.EncryptUserControl.TabIndex = 39;
            this.EncryptUserControl.Visible = false;
            // 
            // SafeKeypMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(813, 532);
            this.Controls.Add(this.EncryptUserControl);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.FormBar);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.PageDescriptionLabel);
            this.Controls.Add(this.EncryptedFileLocationsUserControl);
            this.Controls.Add(this.DecryptUserControl);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SafeKeypMainpage";
            this.Text = "Cypher";
            this.SidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.FormBar.ResumeLayout(false);
            this.FormBar.PerformLayout();
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
        private System.Windows.Forms.Label PageDescriptionLabel;
        private System.Windows.Forms.Label PageLabel;
        private Forms.EncryptUserControl EncryptUserControl;
        private Forms.DecryptUserControl DecryptUserControl;
        private Forms.DirectoriesDisplay EncryptedFileLocationsUserControl;
        private System.Windows.Forms.Timer SafeKeypMainpageTimer;
    }
}

