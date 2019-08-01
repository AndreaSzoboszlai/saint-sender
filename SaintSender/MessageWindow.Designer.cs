namespace SaintSender
{
    partial class MessageWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.emailList = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleFolderLabel = new System.Windows.Forms.Label();
            this.folderDropDown = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // emailList
            // 
            this.emailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Subject,
            this.Time});
            this.emailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailList.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
            this.emailList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.emailList.Location = new System.Drawing.Point(47, 124);
            this.emailList.MultiSelect = false;
            this.emailList.Name = "emailList";
            this.emailList.Size = new System.Drawing.Size(975, 252);
            this.emailList.TabIndex = 0;
            this.emailList.UseCompatibleStateImageBehavior = false;
            this.emailList.View = System.Windows.Forms.View.Details;
            this.emailList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.onEmailSelected);
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 200;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 320;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 200;
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.loadProgressBar.HideProgressText = false;
            this.loadProgressBar.Location = new System.Drawing.Point(47, 391);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(975, 26);
            this.loadProgressBar.TabIndex = 2;
            this.loadProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 448);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(975, 165);
            this.textBox1.TabIndex = 3;
            // 
            // titleFolderLabel
            // 
            this.titleFolderLabel.AutoSize = true;
            this.titleFolderLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFolderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleFolderLabel.Location = new System.Drawing.Point(42, 76);
            this.titleFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.titleFolderLabel.MinimumSize = new System.Drawing.Size(0, 28);
            this.titleFolderLabel.Name = "titleFolderLabel";
            this.titleFolderLabel.Size = new System.Drawing.Size(154, 28);
            this.titleFolderLabel.TabIndex = 7;
            this.titleFolderLabel.Text = "Choose a folder: ";
            // 
            // folderDropDown
            // 
            this.folderDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.folderDropDown.FormattingEnabled = true;
            this.folderDropDown.IntegralHeight = false;
            this.folderDropDown.ItemHeight = 24;
            this.folderDropDown.Location = new System.Drawing.Point(202, 78);
            this.folderDropDown.Name = "folderDropDown";
            this.folderDropDown.Size = new System.Drawing.Size(820, 30);
            this.folderDropDown.TabIndex = 8;
            this.folderDropDown.UseSelectable = true;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 659);
            this.Controls.Add(this.folderDropDown);
            this.Controls.Add(this.titleFolderLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loadProgressBar);
            this.Controls.Add(this.emailList);
            this.Name = "MessageWindow";
            this.Text = "MessageWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView emailList;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Time;
        private MetroFramework.Controls.MetroProgressBar loadProgressBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleFolderLabel;
        private MetroFramework.Controls.MetroComboBox folderDropDown;
    }
}