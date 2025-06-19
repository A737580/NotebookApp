using NotebookApp.Models;
using NotebookApp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NotebookApp.Views.Diary
{
    public partial class DiaryForm : Form
    {
        DiaryModel model;
        MenuForm _menuModel;
        public DiaryForm(DiaryModel diaryModel,MenuForm menuModel)
        {
            InitializeComponent();

            model = diaryModel;
            this._menuModel = menuModel;
            UpdateForm();
        }

        public void UpdateForm()
        {
            List<DiaryEntry> diary = model.DiaryEntriesList;
            LoadListView(diary);
        }

        private void LoadListView(List<DiaryEntry> listToShow)
        {
            DiaryDataGrid.Rows.Clear();
            var orderedList = listToShow.OrderBy(x => x.EntryDate);

            foreach (var item in listToShow)
            {
                string[] row = { DateTimeParser.ToStringWithFormat(item.EntryDate.Date), item.Content };

                DiaryDataGrid.Rows.Add(row);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DiaryDataGrid.Rows != null)
            {
                DialogResult responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = DiaryDataGrid.SelectedRows;
                    model.DeleteEntries(selectedItems);
                }

                List<DiaryEntry> updatedList = model.DiaryEntriesList;
                LoadListView(updatedList);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string queredParameter = QueredParameterCmbBx.Text;
            string query = SearchBox.Text;

            List<DiaryEntry> queredList = model.FindEntry(queredParameter, query);
            LoadListView(queredList);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateUpdateDiaryEntryForm createForm = new CreateUpdateDiaryEntryForm(this, model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = DiaryDataGrid.SelectedRows[0];

            CreateUpdateDiaryEntryForm createForm = new CreateUpdateDiaryEntryForm(this, model, selectedItem);
            createForm.Show();
        }

        private void DiaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menuModel.RefreshEntryCount();
        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
