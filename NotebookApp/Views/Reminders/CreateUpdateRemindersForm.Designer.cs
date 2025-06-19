namespace NotebookApp.Views.Reminders
{
    partial class CreateUpdateRemindersForm
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
            this.EventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EventDescriptionLabel = new System.Windows.Forms.Label();
            this.EventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.CreateUpdateReminderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventDescriptionTextBox
            // 
            this.EventDescriptionTextBox.Location = new System.Drawing.Point(72, 53);
            this.EventDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EventDescriptionTextBox.Name = "EventDescriptionTextBox";
            this.EventDescriptionTextBox.Size = new System.Drawing.Size(265, 22);
            this.EventDescriptionTextBox.TabIndex = 3;
            // 
            // EventDescriptionLabel
            // 
            this.EventDescriptionLabel.AutoSize = true;
            this.EventDescriptionLabel.Location = new System.Drawing.Point(68, 33);
            this.EventDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventDescriptionLabel.Name = "EventDescriptionLabel";
            this.EventDescriptionLabel.Size = new System.Drawing.Size(130, 16);
            this.EventDescriptionLabel.TabIndex = 8;
            this.EventDescriptionLabel.Text = "Название события";
            // 
            // EventDatePicker
            // 
            this.EventDatePicker.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\"";
            this.EventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDatePicker.Location = new System.Drawing.Point(72, 117);
            this.EventDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EventDatePicker.Name = "EventDatePicker";
            this.EventDatePicker.Size = new System.Drawing.Size(265, 22);
            this.EventDatePicker.TabIndex = 9;
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Location = new System.Drawing.Point(68, 97);
            this.EventDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(96, 16);
            this.EventDateLabel.TabIndex = 10;
            this.EventDateLabel.Text = "Дата события";
            // 
            // CreateUpdateReminderBtn
            // 
            this.CreateUpdateReminderBtn.Location = new System.Drawing.Point(72, 178);
            this.CreateUpdateReminderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateUpdateReminderBtn.Name = "CreateUpdateReminderBtn";
            this.CreateUpdateReminderBtn.Size = new System.Drawing.Size(267, 44);
            this.CreateUpdateReminderBtn.TabIndex = 11;
            this.CreateUpdateReminderBtn.Text = "Подтвердить изменения";
            this.CreateUpdateReminderBtn.UseVisualStyleBackColor = true;
            this.CreateUpdateReminderBtn.Click += new System.EventHandler(this.CreateUpdateReminderBtn_Click);
            // 
            // CreateUpdateRemindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 277);
            this.Controls.Add(this.CreateUpdateReminderBtn);
            this.Controls.Add(this.EventDateLabel);
            this.Controls.Add(this.EventDatePicker);
            this.Controls.Add(this.EventDescriptionLabel);
            this.Controls.Add(this.EventDescriptionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUpdateRemindersForm";
            this.Text = "Добавить/обновить событие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EventDescriptionTextBox;
        private System.Windows.Forms.Label EventDescriptionLabel;
        private System.Windows.Forms.DateTimePicker EventDatePicker;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Button CreateUpdateReminderBtn;
    }
}