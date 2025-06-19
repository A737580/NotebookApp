namespace NotebookApp.Views.Diary
{
    partial class CreateUpdateDiaryEntryForm
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.EntryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EntryDateLabel = new System.Windows.Forms.Label();
            this.CreateUpdateDiaryEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.AcceptsReturn = true;
            this.ContentTextBox.Location = new System.Drawing.Point(73, 126);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(799, 286);
            this.ContentTextBox.TabIndex = 3;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(69, 106);
            this.ContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(54, 16);
            this.ContentLabel.TabIndex = 8;
            this.ContentLabel.Text = "Запись";
            // 
            // EntryDatePicker
            // 
            this.EntryDatePicker.Location = new System.Drawing.Point(73, 73);
            this.EntryDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(265, 22);
            this.EntryDatePicker.TabIndex = 9;
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(69, 53);
            this.EntryDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(89, 16);
            this.EntryDateLabel.TabIndex = 10;
            this.EntryDateLabel.Text = "Дата записи";
            // 
            // CreateUpdateDiaryEntryBtn
            // 
            this.CreateUpdateDiaryEntryBtn.Location = new System.Drawing.Point(340, 434);
            this.CreateUpdateDiaryEntryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateUpdateDiaryEntryBtn.Name = "CreateUpdateDiaryEntryBtn";
            this.CreateUpdateDiaryEntryBtn.Size = new System.Drawing.Size(267, 44);
            this.CreateUpdateDiaryEntryBtn.TabIndex = 11;
            this.CreateUpdateDiaryEntryBtn.Text = "Подтвердить изменения";
            this.CreateUpdateDiaryEntryBtn.UseVisualStyleBackColor = true;
            this.CreateUpdateDiaryEntryBtn.Click += new System.EventHandler(this.CreateUpdateDiaryEntryBtn_Click);
            // 
            // CreateUpdateDiaryEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 529);
            this.Controls.Add(this.CreateUpdateDiaryEntryBtn);
            this.Controls.Add(this.EntryDateLabel);
            this.Controls.Add(this.EntryDatePicker);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ContentTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUpdateDiaryEntryForm";
            this.Text = "Создать/изменить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.DateTimePicker EntryDatePicker;
        private System.Windows.Forms.Label EntryDateLabel;
        private System.Windows.Forms.Button CreateUpdateDiaryEntryBtn;
    }
}