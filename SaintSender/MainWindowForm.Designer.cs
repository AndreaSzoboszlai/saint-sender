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
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.titleLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            // 
            // 
            // 
            this.emailBox.CustomButton.Image = null;
            this.emailBox.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.emailBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.CustomButton.Name = "";
            this.emailBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.emailBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailBox.CustomButton.TabIndex = 1;
            this.emailBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailBox.CustomButton.UseSelectable = true;
            this.emailBox.CustomButton.Visible = false;
            this.emailBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.emailBox.ForeColor = System.Drawing.Color.Silver;
            this.emailBox.Lines = new string[] {
        "Email"};
            this.emailBox.Location = new System.Drawing.Point(87, 186);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailBox.SelectedText = "";
            this.emailBox.SelectionLength = 0;
            this.emailBox.SelectionStart = 0;
            this.emailBox.ShortcutsEnabled = true;
            this.emailBox.Size = new System.Drawing.Size(366, 40);
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
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(330, 2);
            this.passwordBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordBox.Lines = new string[] {
        "Password"};
            this.passwordBox.Location = new System.Drawing.Point(87, 245);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(366, 38);
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
            this.metroButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroButton1.Location = new System.Drawing.Point(165, 312);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(195, 46);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.Location = new System.Drawing.Point(236, 115);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(184, 46);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Log in";
            // 
            // titleLogLabel
            // 
            this.titleLogLabel.AutoSize = true;
            this.titleLogLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLogLabel.Location = new System.Drawing.Point(231, 84);
            this.titleLogLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.titleLogLabel.Name = "titleLogLabel";
            this.titleLogLabel.Size = new System.Drawing.Size(73, 28);
            this.titleLogLabel.TabIndex = 6;
            this.titleLogLabel.Text = "Log in";
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 455);
            this.Controls.Add(this.titleLogLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaintSender";
            this.Padding = new System.Windows.Forms.Padding(25, 75, 25, 25);
            this.Text = "Saint Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox emailBox;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private System.Windows.Forms.Label titleLogLabel;
    }
}

