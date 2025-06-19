using NotebookApp.Models;
using NotebookApp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NotebookApp.Views.Reminders
{
    public partial class RemindersForm : Form
    {
        RemindersModel model;
        MenuForm _menuModel;
        public RemindersForm(RemindersModel remindersModel, MenuForm menuModel)
        {
            InitializeComponent();

            model = remindersModel;
            this._menuModel = menuModel;
            UpdateForm();
        }

        public void UpdateForm()
        {
            List<Reminder> remindersList = model.RemindersList;
            LoadListView(remindersList);
        }

        private void LoadListView(List<Reminder> listToShow)
        {
            RemindersListView.Items.Clear();
            var orderedList = listToShow.OrderBy(x => x.EventDate);

            foreach (var item in listToShow)
            {
                string[] row = { DateTimeParser.ToStringWithFormat(item.EventDate), item.Description };
                var listItem = new ListViewItem(row);
                RemindersListView.Items.Add(listItem);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RemindersListView.SelectedItems != null)
            {
                DialogResult responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = RemindersListView.SelectedItems;
                    model.DeleteEntries(selectedItems);
                }

                List<Reminder> updatedList = model.RemindersList;
                LoadListView(updatedList);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string queredParameter = QueredParameterCmbBx.Text;
            string query = SearchBox.Text;

            List<Reminder> queredList = model.FindEntry(queredParameter, query);
            LoadListView(queredList);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateUpdateRemindersForm createForm = new CreateUpdateRemindersForm(this, model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = RemindersListView.SelectedItems[0];

            CreateUpdateRemindersForm createForm = new CreateUpdateRemindersForm(this, model, selectedItem);
            createForm.Show();
        }

        private void ShowUpcomingEventsCount()
        {
            MessageBox.Show($"Количество ближайших событий: {model.UpcomingEventsCount}", "Предупреждение", MessageBoxButtons.OK);
        }

        private void RemindersForm_Load(object sender, EventArgs e)
        {
            if (model.UpcomingEventsCount != 0) ShowUpcomingEventsCount();
        }

        private void RemindersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menuModel.RefreshEntryCount();
        }
    }
}
