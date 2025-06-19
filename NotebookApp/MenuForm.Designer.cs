namespace NotebookApp
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ToFriendsListBtn = new System.Windows.Forms.Button();
            this.ToDiaryBtn = new System.Windows.Forms.Button();
            this.ToRemindersBtn = new System.Windows.Forms.Button();
            this.ShowCountEntry = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(359, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Записная книжка";
            // 
            // ToFriendsListBtn
            // 
            this.ToFriendsListBtn.Location = new System.Drawing.Point(363, 171);
            this.ToFriendsListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToFriendsListBtn.Name = "ToFriendsListBtn";
            this.ToFriendsListBtn.Size = new System.Drawing.Size(341, 62);
            this.ToFriendsListBtn.TabIndex = 1;
            this.ToFriendsListBtn.Text = "Список знакомых";
            this.ToFriendsListBtn.UseVisualStyleBackColor = true;
            this.ToFriendsListBtn.Click += new System.EventHandler(this.ToFriendsListBtn_Click);
            // 
            // ToDiaryBtn
            // 
            this.ToDiaryBtn.Location = new System.Drawing.Point(363, 257);
            this.ToDiaryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToDiaryBtn.Name = "ToDiaryBtn";
            this.ToDiaryBtn.Size = new System.Drawing.Size(341, 62);
            this.ToDiaryBtn.TabIndex = 2;
            this.ToDiaryBtn.Text = "Ежедневник";
            this.ToDiaryBtn.UseVisualStyleBackColor = true;
            this.ToDiaryBtn.Click += new System.EventHandler(this.ToDiaryBtn_Click);
            // 
            // ToRemindersBtn
            // 
            this.ToRemindersBtn.Location = new System.Drawing.Point(363, 343);
            this.ToRemindersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToRemindersBtn.Name = "ToRemindersBtn";
            this.ToRemindersBtn.Size = new System.Drawing.Size(341, 62);
            this.ToRemindersBtn.TabIndex = 3;
            this.ToRemindersBtn.Text = "Напоминания";
            this.ToRemindersBtn.UseVisualStyleBackColor = true;
            this.ToRemindersBtn.Click += new System.EventHandler(this.ToRemindersBtn_Click);
            // 
            // ShowCountEntry
            // 
            this.ShowCountEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowCountEntry.Location = new System.Drawing.Point(12, 64);
            this.ShowCountEntry.Name = "ShowCountEntry";
            this.ShowCountEntry.Size = new System.Drawing.Size(260, 64);
            this.ShowCountEntry.TabIndex = 4;
            this.ShowCountEntry.Text = "";
            this.ShowCountEntry.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShowCountEntry);
            this.Controls.Add(this.ToRemindersBtn);
            this.Controls.Add(this.ToDiaryBtn);
            this.Controls.Add(this.ToFriendsListBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Записная книжка";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Enter += new System.EventHandler(this.MenuForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToFriendsListBtn;
        private System.Windows.Forms.Button ToDiaryBtn;
        private System.Windows.Forms.Button ToRemindersBtn;
        private System.Windows.Forms.RichTextBox ShowCountEntry;
    }
}

