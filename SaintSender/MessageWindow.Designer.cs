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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.emailList = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // emailList
            // 
            this.emailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Subject,
            this.Time});
            this.emailList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.emailList.Location = new System.Drawing.Point(50, 89);
            this.emailList.Name = "emailList";
            this.emailList.Size = new System.Drawing.Size(903, 252);
            this.emailList.TabIndex = 0;
            this.emailList.UseCompatibleStateImageBehavior = false;
            this.emailList.View = System.Windows.Forms.View.Details;
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
            this.Time.Width = 140;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 348);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(903, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 569);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.emailList);
            this.Name = "MessageWindow";
            this.Text = "MessageWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView emailList;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}