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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeKeypMainpage));
            this.FormBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ChangeTextTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EncryptButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FormBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBar
            // 
            this.FormBar.BackColor = System.Drawing.Color.Lime;
            this.FormBar.Controls.Add(this.MinimizeButton);
            this.FormBar.Controls.Add(this.CloseButton);
            this.FormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBar.Location = new System.Drawing.Point(0, 0);
            this.FormBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FormBar.Name = "FormBar";
            this.FormBar.Size = new System.Drawing.Size(400, 32);
            this.FormBar.TabIndex = 28;
            this.FormBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseDown);
            this.FormBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseMove);
            this.FormBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormBar_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AnimationHoverSpeed = 0.07F;
            this.MinimizeButton.AnimationSpeed = 0.03F;
            this.MinimizeButton.BaseColor = System.Drawing.Color.Black;
            this.MinimizeButton.BorderColor = System.Drawing.Color.Lime;
            this.MinimizeButton.BorderSize = 1;
            this.MinimizeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MinimizeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.CheckedForeColor = System.Drawing.Color.White;
            this.MinimizeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.CheckedImage")));
            this.MinimizeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.Lime;
            this.MinimizeButton.Image = null;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MinimizeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.MinimizeButton.Location = new System.Drawing.Point(334, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.MinimizeButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnHoverImage = null;
            this.MinimizeButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 44;
            this.MinimizeButton.Text = " __";
            this.MinimizeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.Red;
            this.CloseButton.BorderColor = System.Drawing.Color.Lime;
            this.CloseButton.BorderSize = 1;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.CheckedImage")));
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(367, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.Red;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 43;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChangeTextTimer
            // 
            this.ChangeTextTimer.Tick += new System.EventHandler(this.SafeKeypMainpageTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, -151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 672);
            this.label1.TabIndex = 31;
            this.label1.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n" +
    "8\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(87, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "SafeKeyp: A file encryptor";
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 50;
            this.MoveTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(323, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 384);
            this.label9.TabIndex = 39;
            this.label9.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(369, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 384);
            this.label7.TabIndex = 32;
            this.label7.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(53, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 384);
            this.label8.TabIndex = 38;
            this.label8.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(86, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 384);
            this.label2.TabIndex = 36;
            this.label2.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(284, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 384);
            this.label6.TabIndex = 34;
            this.label6.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(191, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 384);
            this.label4.TabIndex = 35;
            this.label4.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(249, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 384);
            this.label5.TabIndex = 37;
            this.label5.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 384);
            this.label3.TabIndex = 33;
            this.label3.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n3\r\n4";
            // 
            // DecryptButton
            // 
            this.DecryptButton.AnimationHoverSpeed = 0.07F;
            this.DecryptButton.AnimationSpeed = 0.03F;
            this.DecryptButton.BaseColor = System.Drawing.Color.Black;
            this.DecryptButton.BorderColor = System.Drawing.Color.Lime;
            this.DecryptButton.BorderSize = 1;
            this.DecryptButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DecryptButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.DecryptButton.CheckedForeColor = System.Drawing.Color.White;
            this.DecryptButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DecryptButton.CheckedImage")));
            this.DecryptButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DecryptButton.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.ForeColor = System.Drawing.Color.Lime;
            this.DecryptButton.Image = null;
            this.DecryptButton.ImageSize = new System.Drawing.Size(20, 20);
            this.DecryptButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DecryptButton.Location = new System.Drawing.Point(108, 232);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.DecryptButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.DecryptButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.DecryptButton.OnHoverImage = null;
            this.DecryptButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.DecryptButton.OnPressedColor = System.Drawing.Color.Black;
            this.DecryptButton.Size = new System.Drawing.Size(190, 53);
            this.DecryptButton.TabIndex = 41;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.AnimationHoverSpeed = 0.07F;
            this.EncryptButton.AnimationSpeed = 0.03F;
            this.EncryptButton.BaseColor = System.Drawing.Color.Black;
            this.EncryptButton.BorderColor = System.Drawing.Color.Lime;
            this.EncryptButton.BorderSize = 1;
            this.EncryptButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EncryptButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.EncryptButton.CheckedForeColor = System.Drawing.Color.White;
            this.EncryptButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EncryptButton.CheckedImage")));
            this.EncryptButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EncryptButton.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.ForeColor = System.Drawing.Color.Lime;
            this.EncryptButton.Image = null;
            this.EncryptButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EncryptButton.LineColor = System.Drawing.Color.Lime;
            this.EncryptButton.Location = new System.Drawing.Point(108, 114);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.EncryptButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.EncryptButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.EncryptButton.OnHoverImage = null;
            this.EncryptButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.EncryptButton.OnPressedColor = System.Drawing.Color.Black;
            this.EncryptButton.Size = new System.Drawing.Size(190, 53);
            this.EncryptButton.TabIndex = 40;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // SafeKeypMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.FormBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SafeKeypMainpage";
            this.Text = "Cypher";
            this.FormBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel FormBar;
        private System.Windows.Forms.Timer ChangeTextTimer;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton EncryptButton;
        private Guna.UI.WinForms.GunaAdvenceButton DecryptButton;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaAdvenceButton MinimizeButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

