namespace NotebookApp.Views.Diary
{
    partial class DiaryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.QueredParameterCmbBx = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DiaryDataGrid = new System.Windows.Forms.DataGridView();
            this.EntryDateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryContentHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DiaryDataGrid)).BeginInit();
            this.SuspendLayout();
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
            "Запись"});
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
            // DiaryDataGrid
            // 
            this.DiaryDataGrid.AllowUserToAddRows = false;
            this.DiaryDataGrid.AllowUserToDeleteRows = false;
            this.DiaryDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DiaryDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntryDateHeader,
            this.EntryContentHeader});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiaryDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DiaryDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DiaryDataGrid.Location = new System.Drawing.Point(16, 75);
            this.DiaryDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DiaryDataGrid.Name = "DiaryDataGrid";
            this.DiaryDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiaryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiaryDataGrid.RowHeadersVisible = false;
            this.DiaryDataGrid.RowHeadersWidth = 51;
            this.DiaryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiaryDataGrid.Size = new System.Drawing.Size(1033, 478);
            this.DiaryDataGrid.TabIndex = 7;
            // 
            // EntryDateHeader
            // 
            this.EntryDateHeader.FillWeight = 31.08808F;
            this.EntryDateHeader.HeaderText = "Дата записи";
            this.EntryDateHeader.MinimumWidth = 6;
            this.EntryDateHeader.Name = "EntryDateHeader";
            this.EntryDateHeader.ReadOnly = true;
            this.EntryDateHeader.Width = 120;
            // 
            // EntryContentHeader
            // 
            this.EntryContentHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EntryContentHeader.FillWeight = 168.9119F;
            this.EntryContentHeader.HeaderText = "Запись";
            this.EntryContentHeader.MinimumWidth = 6;
            this.EntryContentHeader.Name = "EntryContentHeader";
            this.EntryContentHeader.ReadOnly = true;
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 657);
            this.Controls.Add(this.DiaryDataGrid);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.QueredParameterCmbBx);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiaryForm";
            this.Text = "Ежедневник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiaryForm_FormClosing);
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiaryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.ComboBox QueredParameterCmbBx;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DiaryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryContentHeader;
    }
}