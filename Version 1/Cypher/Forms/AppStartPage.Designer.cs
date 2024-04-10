namespace Cypher
{
    partial class AppStartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActiveControl = null;
            panel2 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SigninButton = new Label();
            LoginButton = new Label();
            panel3 = new Panel();
            UsernameBox = new Forms.CypherTextBox();
            panel4 = new Panel();
            PasswordBox = new Forms.CypherTextBox();
            panel5 = new Panel();
            RememberUsername = new CheckBox();
            panel6 = new Panel();
            MainButton = new Button();
            panel7 = new Panel();
            ResultLabel = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(179, 190, 209);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 87);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 54, 77);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(7);
            label1.Name = "label1";
            label1.Size = new Size(234, 87);
            label1.TabIndex = 0;
            label1.Text = "Cypher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SigninButton, 1, 0);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 87);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(234, 48);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // SigninButton
            // 
            SigninButton.AutoSize = true;
            SigninButton.Dock = DockStyle.Fill;
            SigninButton.Font = new Font("Bahnschrift Light Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SigninButton.Location = new Point(120, 4);
            SigninButton.Margin = new Padding(3, 4, 3, 4);
            SigninButton.Name = "SigninButton";
            SigninButton.Size = new Size(111, 40);
            SigninButton.TabIndex = 1;
            SigninButton.Text = "Sign Up";
            SigninButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Font = new Font("Bahnschrift Light Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(3, 4);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 40);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Log In";
            LoginButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(UsernameBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 135);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 71);
            panel3.TabIndex = 5;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsernameBox.BackColor = SystemColors.Window;
            UsernameBox.BorderColor = Color.FromArgb(103, 192, 201);
            UsernameBox.BorderSize = 0;
            UsernameBox.FocusedColors = Color.FromArgb(179, 190, 209);
            UsernameBox.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.ForeColor = Color.FromArgb(46, 54, 77);
            UsernameBox.isPassword = false;
            UsernameBox.Location = new Point(7, 13);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Padding = new Padding(8, 9, 8, 9);
            UsernameBox.Placeholder = "Username";
            UsernameBox.Size = new Size(221, 42);
            UsernameBox.TabIndex = 0;
            UsernameBox.UnderlinedStyle = true;
            UsernameBox.Enter += UsernameBox_Enter;
            UsernameBox.Leave += UsernameBox_Leave;
            // 
            // panel4
            // 
            panel4.Controls.Add(PasswordBox);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 206);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 57);
            panel4.TabIndex = 6;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PasswordBox.BackColor = SystemColors.Window;
            PasswordBox.BorderColor = Color.FromArgb(103, 192, 201);
            PasswordBox.BorderSize = 0;
            PasswordBox.FocusedColors = Color.FromArgb(179, 190, 209);
            PasswordBox.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.FromArgb(46, 54, 77);
            PasswordBox.isPassword = false;
            PasswordBox.Location = new Point(7, 7);
            PasswordBox.Margin = new Padding(3, 4, 3, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Padding = new Padding(8, 9, 8, 9);
            PasswordBox.Placeholder = "Password";
            PasswordBox.Size = new Size(221, 42);
            PasswordBox.TabIndex = 1;
            PasswordBox.UnderlinedStyle = true;
            PasswordBox.Enter += PasswordBox_Enter;
            PasswordBox.Leave += PasswordBox_Leave;
            // 
            // panel5
            // 
            panel5.Controls.Add(RememberUsername);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 263);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 32);
            panel5.TabIndex = 7;
            // 
            // RememberUsername
            // 
            RememberUsername.AutoSize = true;
            RememberUsername.FlatAppearance.BorderSize = 0;
            RememberUsername.FlatStyle = FlatStyle.Flat;
            RememberUsername.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RememberUsername.Location = new Point(7, 3);
            RememberUsername.Margin = new Padding(3, 4, 3, 4);
            RememberUsername.Name = "RememberUsername";
            RememberUsername.Size = new Size(124, 21);
            RememberUsername.TabIndex = 4;
            RememberUsername.Text = "Remember Username";
            RememberUsername.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(MainButton);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 295);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 53);
            panel6.TabIndex = 8;
            // 
            // MainButton
            // 
            MainButton.FlatStyle = FlatStyle.Flat;
            MainButton.Location = new Point(7, 8);
            MainButton.Margin = new Padding(3, 4, 3, 4);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(113, 36);
            MainButton.TabIndex = 0;
            MainButton.Text = "Login";
            MainButton.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(ResultLabel);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 348);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 100);
            panel7.TabIndex = 9;
            // 
            // ResultLabel
            // 
            ResultLabel.Dock = DockStyle.Fill;
            ResultLabel.Font = new Font("Bahnschrift Light Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.Location = new Point(0, 0);
            ResultLabel.Margin = new Padding(10);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(234, 100);
            ResultLabel.TabIndex = 1;
            ResultLabel.Text = "Log In";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 600);
            panel1.TabIndex = 0;
            // 
            // AppStartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppStartPage";
            Text = "Cypher";
      
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label SigninButton;
        private Label LoginButton;
        private Panel panel3;
        private Forms.CypherTextBox UsernameBox;
        private Panel panel4;
        private Forms.CypherTextBox PasswordBox;
        private Panel panel5;
        private CheckBox RememberUsername;
        private Panel panel6;
        private Button MainButton;
        private Panel panel7;
        private Label ResultLabel;
        private Panel panel1;
    }
}
