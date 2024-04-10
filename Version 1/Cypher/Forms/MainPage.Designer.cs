namespace Cypher.Forms
{
    partial class MainPage
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
            SidemenuPanel = new Panel();
            label1 = new Label();
            HowtouseButton = new Button();
            DecryptButton = new Button();
            EncryptButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            panel2 = new Panel();
            KeyInputBox = new CypherTextBox();
            FeedbackLabel = new Label();
            ActionButton = new Button();
            SelectedFileName = new Label();
            SelectButton = new Button();
            PageLabel = new Label();
            SidemenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SidemenuPanel
            // 
            SidemenuPanel.Controls.Add(label1);
            SidemenuPanel.Controls.Add(HowtouseButton);
            SidemenuPanel.Controls.Add(DecryptButton);
            SidemenuPanel.Controls.Add(EncryptButton);
            SidemenuPanel.Dock = DockStyle.Top;
            SidemenuPanel.Location = new Point(0, 0);
            SidemenuPanel.Name = "SidemenuPanel";
            SidemenuPanel.Size = new Size(714, 78);
            SidemenuPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 22F);
            label1.ForeColor = Color.FromArgb(46, 54, 77);
            label1.Location = new Point(287, 17);
            label1.Name = "label1";
            label1.Size = new Size(412, 45);
            label1.TabIndex = 5;
            label1.Text = "Cypher: A file encryptor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HowtouseButton
            // 
            HowtouseButton.Dock = DockStyle.Left;
            HowtouseButton.FlatStyle = FlatStyle.Flat;
            HowtouseButton.Font = new Font("Bahnschrift Light", 8.5F);
            HowtouseButton.Location = new Point(188, 0);
            HowtouseButton.Name = "HowtouseButton";
            HowtouseButton.Size = new Size(94, 78);
            HowtouseButton.TabIndex = 4;
            HowtouseButton.Text = "How To Use";
            HowtouseButton.UseVisualStyleBackColor = true;
            HowtouseButton.Click += HowtouseButton_Click;
            HowtouseButton.MouseEnter += HowtouseButton_MouseEnter;
            HowtouseButton.MouseLeave += HowtouseButton_MouseLeave;
            // 
            // DecryptButton
            // 
            DecryptButton.Dock = DockStyle.Left;
            DecryptButton.FlatStyle = FlatStyle.Flat;
            DecryptButton.Font = new Font("Bahnschrift Light", 9F);
            DecryptButton.Location = new Point(94, 0);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(94, 78);
            DecryptButton.TabIndex = 2;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            DecryptButton.MouseEnter += DecryptButton_MouseEnter;
            DecryptButton.MouseLeave += DecryptButton_MouseLeave;
            // 
            // EncryptButton
            // 
            EncryptButton.Dock = DockStyle.Left;
            EncryptButton.FlatStyle = FlatStyle.Flat;
            EncryptButton.Font = new Font("Bahnschrift Light", 9F);
            EncryptButton.Location = new Point(0, 0);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(94, 78);
            EncryptButton.TabIndex = 1;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            EncryptButton.MouseEnter += EncryptButton_MouseEnter;
            EncryptButton.MouseLeave += EncryptButton_MouseLeave;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 377);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(KeyInputBox);
            panel2.Controls.Add(FeedbackLabel);
            panel2.Controls.Add(ActionButton);
            panel2.Controls.Add(SelectedFileName);
            panel2.Controls.Add(SelectButton);
            panel2.Controls.Add(PageLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 377);
            panel2.TabIndex = 23;
            // 
            // KeyInputBox
            // 
            KeyInputBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KeyInputBox.BackColor = SystemColors.Window;
            KeyInputBox.BorderColor = Color.FromArgb(128, 128, 255);
            KeyInputBox.BorderSize = 2;
            KeyInputBox.FocusedColors = Color.FromArgb(192, 192, 255);
            KeyInputBox.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyInputBox.ForeColor = Color.FromArgb(46, 54, 77);
            KeyInputBox.isPassword = false;
            KeyInputBox.Location = new Point(15, 87);
            KeyInputBox.Name = "KeyInputBox";
            KeyInputBox.Padding = new Padding(7);
            KeyInputBox.Placeholder = "Input Key";
            KeyInputBox.Size = new Size(312, 36);
            KeyInputBox.TabIndex = 28;
            KeyInputBox.UnderlinedStyle = false;
            KeyInputBox.Visible = false;
            KeyInputBox.Enter += SeedInputBox_Enter;
            KeyInputBox.Leave += SeedInputBox_Leave;
            // 
            // FeedbackLabel
            // 
            FeedbackLabel.AutoSize = true;
            FeedbackLabel.Font = new Font("Bahnschrift Light", 9F);
            FeedbackLabel.Location = new Point(148, 19);
            FeedbackLabel.Name = "FeedbackLabel";
            FeedbackLabel.Size = new Size(74, 18);
            FeedbackLabel.TabIndex = 27;
            FeedbackLabel.Text = "Response";
            // 
            // ActionButton
            // 
            ActionButton.FlatStyle = FlatStyle.Flat;
            ActionButton.Font = new Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActionButton.Location = new Point(115, 42);
            ActionButton.Name = "ActionButton";
            ActionButton.Size = new Size(176, 29);
            ActionButton.TabIndex = 26;
            ActionButton.Text = "Action";
            ActionButton.UseVisualStyleBackColor = true;
            // 
            // SelectedFileName
            // 
            SelectedFileName.AutoSize = true;
            SelectedFileName.Font = new Font("Bahnschrift Light", 9F);
            SelectedFileName.Location = new Point(15, 144);
            SelectedFileName.Name = "SelectedFileName";
            SelectedFileName.Size = new Size(101, 18);
            SelectedFileName.TabIndex = 25;
            SelectedFileName.Text = "Files Selected";
            // 
            // SelectButton
            // 
            SelectButton.FlatStyle = FlatStyle.Flat;
            SelectButton.Font = new Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectButton.Location = new Point(15, 42);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 29);
            SelectButton.TabIndex = 24;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.Location = new Point(10, 9);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(134, 30);
            PageLabel.TabIndex = 23;
            PageLabel.Text = "MenuLabel";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 158, 158);
            ClientSize = new Size(714, 455);
            Controls.Add(panel1);
            Controls.Add(SidemenuPanel);
            Name = "MainPage";
            Text = "Cypher";
            FormClosed += MainPage_FormClosed;
            SidemenuPanel.ResumeLayout(false);
            SidemenuPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidemenuPanel;
        private Button EncryptButton;
        private Button HowtouseButton;
        private Button DecryptButton;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Panel panel2;
        private Label FeedbackLabel;
        private Button ActionButton;
        private Label SelectedFileName;
        private Button SelectButton;
        private Label PageLabel;
        private CypherTextBox KeyInputBox;
    }
}