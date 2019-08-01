namespace SaintSender
{
    partial class SaintSender
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
            this.emailBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.titleLogLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            // 
            // 
            // 
            this.emailBox.CustomButton.Image = null;
            this.emailBox.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.emailBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.CustomButton.Name = "";
            this.emailBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.emailBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailBox.CustomButton.TabIndex = 1;
            this.emailBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailBox.CustomButton.UseSelectable = true;
            this.emailBox.CustomButton.Visible = false;
            this.emailBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailBox.ForeColor = System.Drawing.Color.Silver;
            this.emailBox.Lines = new string[] {
        "Email"};
            this.emailBox.Location = new System.Drawing.Point(62, 135);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailBox.SelectedText = "";
            this.emailBox.SelectionLength = 0;
            this.emailBox.SelectionStart = 0;
            this.emailBox.ShortcutsEnabled = true;
            this.emailBox.Size = new System.Drawing.Size(249, 25);
            this.emailBox.TabIndex = 0;
            this.emailBox.Text = "Email";
            this.emailBox.UseSelectable = true;
            this.emailBox.UseStyleColors = true;
            this.emailBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.passwordBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordBox.Lines = new string[] {
        "Password"};
            this.passwordBox.Location = new System.Drawing.Point(62, 183);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(249, 25);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Password";
            this.passwordBox.UseSelectable = true;
            this.passwordBox.UseStyleColors = true;
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroButton1.Location = new System.Drawing.Point(117, 233);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 36);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Sign in";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // titleLogLabel
            // 
            this.titleLogLabel.AutoSize = true;
            this.titleLogLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLogLabel.Location = new System.Drawing.Point(156, 76);
            this.titleLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.titleLogLabel.MinimumSize = new System.Drawing.Size(0, 28);
            this.titleLogLabel.Name = "titleLogLabel";
            this.titleLogLabel.Size = new System.Drawing.Size(91, 38);
            this.titleLogLabel.TabIndex = 6;
            this.titleLogLabel.Text = "Log in";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(121, 84);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 314);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.titleLogLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "SaintSender";
            this.Text = "Saint Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox emailBox;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label titleLogLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

