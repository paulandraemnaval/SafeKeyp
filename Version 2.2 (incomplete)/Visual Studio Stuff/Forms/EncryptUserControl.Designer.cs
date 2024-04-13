﻿namespace CypherWithGuna.Forms
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
            this.DeleteRadioButton = new Guna.UI.WinForms.GunaCheckBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.SelectedFileName = new System.Windows.Forms.Label();
            this.ConfirmKeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.KeyInputBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.KeyPeekButton = new System.Windows.Forms.Button();
            this.ConfirmKeyPeekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.BaseColor = System.Drawing.Color.White;
            this.DeleteRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.DeleteRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteRadioButton.FillColor = System.Drawing.Color.White;
            this.DeleteRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRadioButton.Location = new System.Drawing.Point(20, 155);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(157, 28);
            this.DeleteRadioButton.TabIndex = 49;
            this.DeleteRadioButton.Text = "Delete file after ";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FeedbackLabel.Location = new System.Drawing.Point(17, 211);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(118, 30);
            this.FeedbackLabel.TabIndex = 46;
            this.FeedbackLabel.Text = "Feedback";
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.AutoSize = true;
            this.SelectedFileName.BackColor = System.Drawing.Color.Transparent;
            this.SelectedFileName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileName.Location = new System.Drawing.Point(17, 186);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(127, 24);
            this.SelectedFileName.TabIndex = 45;
            this.SelectedFileName.Text = "Selected File";
            // 
            // ConfirmKeyInputBox
            // 
            this.ConfirmKeyInputBox.BackColor = System.Drawing.Color.White;
            this.ConfirmKeyInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmKeyInputBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ConfirmKeyInputBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyInputBox.LineColor = System.Drawing.Color.Gainsboro;
            this.ConfirmKeyInputBox.Location = new System.Drawing.Point(21, 114);
            this.ConfirmKeyInputBox.Name = "ConfirmKeyInputBox";
            this.ConfirmKeyInputBox.PasswordChar = '\0';
            this.ConfirmKeyInputBox.Size = new System.Drawing.Size(383, 35);
            this.ConfirmKeyInputBox.TabIndex = 44;
            this.ConfirmKeyInputBox.Text = "Confirm Key";
            this.ConfirmKeyInputBox.TextChanged += new System.EventHandler(this.ConfirmKeyInputBox_TextChanged);
            this.ConfirmKeyInputBox.Enter += new System.EventHandler(this.ConfirmKeyInputBox_Enter);
            this.ConfirmKeyInputBox.Leave += new System.EventHandler(this.ConfirmKeyInputBox_Leave);
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
            this.ActionButton.TabIndex = 43;
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
            this.SelectButton.TabIndex = 42;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Visible = false;
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
            this.KeyInputBox.TabIndex = 41;
            this.KeyInputBox.Text = "Enter Key";
            this.KeyInputBox.TextChanged += new System.EventHandler(this.KeyInputBox_TextChanged);
            this.KeyInputBox.Enter += new System.EventHandler(this.KeyInputBox_Enter);
            this.KeyInputBox.Leave += new System.EventHandler(this.KeyInputBox_Leave);
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
            this.KeyPeekButton.TabIndex = 47;
            this.KeyPeekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KeyPeekButton.UseVisualStyleBackColor = false;
            this.KeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseDown);
            this.KeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PeekButton_MouseUp);
            // 
            // ConfirmKeyPeekButton
            // 
            this.ConfirmKeyPeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.ConfirmKeyPeekButton.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmKeyPeekButton.Image = global::CypherWithGuna.Properties.Resources.icons8_eye_24;
            this.ConfirmKeyPeekButton.Location = new System.Drawing.Point(410, 114);
            this.ConfirmKeyPeekButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmKeyPeekButton.Name = "ConfirmKeyPeekButton";
            this.ConfirmKeyPeekButton.Size = new System.Drawing.Size(41, 35);
            this.ConfirmKeyPeekButton.TabIndex = 48;
            this.ConfirmKeyPeekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConfirmKeyPeekButton.UseVisualStyleBackColor = false;
            this.ConfirmKeyPeekButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseDown);
            this.ConfirmKeyPeekButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConfirmKeyPeekButton_MouseUp);
            // 
            // EncryptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.KeyPeekButton);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.SelectedFileName);
            this.Controls.Add(this.ConfirmKeyInputBox);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.KeyInputBox);
            this.Controls.Add(this.ConfirmKeyPeekButton);
            this.Name = "EncryptUserControl";
            this.Size = new System.Drawing.Size(464, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox DeleteRadioButton;
        private System.Windows.Forms.Button KeyPeekButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label SelectedFileName;
        private Guna.UI.WinForms.GunaLineTextBox ConfirmKeyInputBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button SelectButton;
        private Guna.UI.WinForms.GunaLineTextBox KeyInputBox;
        private System.Windows.Forms.Button ConfirmKeyPeekButton;
    }
}