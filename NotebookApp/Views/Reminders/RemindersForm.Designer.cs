namespace NotebookApp.Views.Reminders
{
    partial class RemindersForm
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
            this.RemindersListView = new System.Windows.Forms.ListView();
            this.EventDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.QueredParameterCmbBx = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemindersListView
            // 
            this.RemindersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventDateHeader,
            this.DescriptionHeader});
            this.RemindersListView.FullRowSelect = true;
            this.RemindersListView.GridLines = true;
            this.RemindersListView.HideSelection = false;
            this.RemindersListView.Location = new System.Drawing.Point(16, 66);
            this.RemindersListView.Margin = new System.Windows.Forms.Padding(4);
            this.RemindersListView.Name = "RemindersListView";
            this.RemindersListView.Size = new System.Drawing.Size(1033, 490);
            this.RemindersListView.TabIndex = 0;
            this.RemindersListView.UseCompatibleStateImageBehavior = false;
            this.RemindersListView.View = System.Windows.Forms.View.Details;
            // 
            // EventDateHeader
            // 
            this.EventDateHeader.Text = "Дата события";
            this.EventDateHeader.Width = 150;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Событие";
            this.DescriptionHeader.Width = 600;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(16, 577);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(260, 49);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Добавить новую запись";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(403, 577);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(260, 49);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Удалить существующую запись";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(789, 577);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(260, 49);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Обновить информацию о записи";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(935, 20);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(115, 30);
            this.FindBtn.TabIndex = 4;
            this.FindBtn.Text = "Найти";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // QueredParameterCmbBx
            // 
            this.QueredParameterCmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.QueredParameterCmbBx.FormattingEnabled = true;
            this.QueredParameterCmbBx.Items.AddRange(new object[] {
            "",
            "Дата",
            "Событие"});
            this.QueredParameterCmbBx.Location = new System.Drawing.Point(16, 20);
            this.QueredParameterCmbBx.Margin = new System.Windows.Forms.Padding(4);
            this.QueredParameterCmbBx.Name = "QueredParameterCmbBx";
            this.QueredParameterCmbBx.Size = new System.Drawing.Size(179, 30);
            this.QueredParameterCmbBx.TabIndex = 5;
            this.QueredParameterCmbBx.Text = "Столбец...";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SearchBox.Location = new System.Drawing.Point(221, 20);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(687, 28);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.WordWrap = false;
            // 
            // RemindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 657);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.QueredParameterCmbBx);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.RemindersListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemindersForm";
            this.Text = "Напоминания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemindersForm_FormClosing);
            this.Load += new System.EventHandler(this.RemindersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView RemindersListView;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.ColumnHeader EventDateHeader;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.ComboBox QueredParameterCmbBx;
        private System.Windows.Forms.TextBox SearchBox;
    }
}