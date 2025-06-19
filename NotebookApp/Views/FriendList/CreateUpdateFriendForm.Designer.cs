namespace NotebookApp.Views.FriendsList
{
    partial class CreateUpdateFriendForm
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateFriendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(73, 74);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(73, 154);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(265, 22);
            this.AddressTextBox.TabIndex = 1;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(73, 234);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(265, 22);
            this.PhoneTextBox.TabIndex = 2;
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(73, 314);
            this.RemarkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(265, 22);
            this.RemarkTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(69, 54);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(38, 16);
            this.FullNameLabel.TabIndex = 5;
            this.FullNameLabel.Text = "ФИО";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(69, 134);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 16);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Адрес";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(69, 214);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(119, 16);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(69, 294);
            this.RemarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(160, 16);
            this.RemarkLabel.TabIndex = 8;
            this.RemarkLabel.Text = "Короткий комментарий";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(73, 378);
            this.BirthDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(265, 22);
            this.BirthDatePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата рождения";
            // 
            // CreateFriendBtn
            // 
            this.CreateFriendBtn.Location = new System.Drawing.Point(73, 439);
            this.CreateFriendBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateFriendBtn.Name = "CreateFriendBtn";
            this.CreateFriendBtn.Size = new System.Drawing.Size(267, 44);
            this.CreateFriendBtn.TabIndex = 11;
            this.CreateFriendBtn.Text = "Подтвердить изменения";
            this.CreateFriendBtn.UseVisualStyleBackColor = true;
            this.CreateFriendBtn.Click += new System.EventHandler(this.CreateUpdateFriendBtn_Click);
            // 
            // CreateUpdateFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 554);
            this.Controls.Add(this.CreateFriendBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.RemarkLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.RemarkTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateUpdateFriendForm";
            this.Text = "Создать/изменить запись";
            this.Load += new System.EventHandler(this.CreateUpdateFriendForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateFriendBtn;
    }
}