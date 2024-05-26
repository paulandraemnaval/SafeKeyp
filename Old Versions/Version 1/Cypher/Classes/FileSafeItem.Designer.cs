namespace Cypher
{
    partial class FileSafeItem
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
            panel1 = new Panel();
            FileIcon = new PictureBox();
            ItemIcon = new PictureBox();
            panel3 = new Panel();
            ActionButton = new Button();
            RemoveButton = new Button();
            FileNameLabel = new Label();
            ActionFeedback = new Label();
            panel2 = new Panel();
            File = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FileIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemIcon).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 190, 209);
            panel1.Controls.Add(FileIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 105);
            panel1.TabIndex = 0;
            // 
            // FileIcon
            // 
            FileIcon.Location = new Point(9, 11);
            FileIcon.Name = "FileIcon";
            FileIcon.Size = new Size(84, 84);
            FileIcon.TabIndex = 0;
            FileIcon.TabStop = false;
            // 
            // ItemIcon
            // 
            ItemIcon.Dock = DockStyle.Fill;
            ItemIcon.Location = new Point(0, 0);
            ItemIcon.Name = "ItemIcon";
            ItemIcon.Size = new Size(104, 105);
            ItemIcon.TabIndex = 0;
            ItemIcon.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(RemoveButton);
            panel3.Controls.Add(ActionButton);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(501, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 105);
            panel3.TabIndex = 4;
            // 
            // ActionButton
            // 
            ActionButton.Dock = DockStyle.Top;
            ActionButton.FlatStyle = FlatStyle.Flat;
            ActionButton.Font = new Font("Bahnschrift Light", 9F);
            ActionButton.Location = new Point(0, 0);
            ActionButton.Name = "ActionButton";
            ActionButton.Size = new Size(195, 52);
            ActionButton.TabIndex = 0;
            ActionButton.Text = "Action";
            ActionButton.UseVisualStyleBackColor = true;
            ActionButton.Click += ActionButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Top;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Bahnschrift Light", 9F);
            RemoveButton.ForeColor = Color.Red;
            RemoveButton.Location = new Point(0, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(195, 52);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove From File Safe";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileNameLabel.Location = new Point(6, 11);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(91, 36);
            FileNameLabel.TabIndex = 5;
            FileNameLabel.Text = "label1";
            // 
            // ActionFeedback
            // 
            ActionFeedback.AutoSize = true;
            ActionFeedback.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActionFeedback.Location = new Point(10, 47);
            ActionFeedback.Name = "ActionFeedback";
            ActionFeedback.Size = new Size(0, 21);
            ActionFeedback.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(File);
            panel2.Controls.Add(ActionFeedback);
            panel2.Controls.Add(FileNameLabel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(104, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 105);
            panel2.TabIndex = 1;
            // 
            // File
            // 
            File.AutoSize = true;
            File.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File.Location = new Point(303, 34);
            File.Name = "File";
            File.Size = new Size(91, 36);
            File.TabIndex = 7;
            File.Text = "label1";
            // 
            // FileSafeItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FileSafeItem";
            Size = new Size(800, 105);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FileIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemIcon).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DecryptButton;
        private PictureBox ItemIcon;
        private PictureBox FileIcon;
        private Label ItemDescription;
        private Panel panel3;
        private Button RemoveButton;
        private Button ActionButton;
        private Label FileNameLabel;
        private Label ActionFeedback;
        private Panel panel2;
        private Label File;
    }
}
