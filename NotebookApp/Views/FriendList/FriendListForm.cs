using NotebookApp.Models;
using NotebookApp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NotebookApp.Views.FriendsList
{
    public partial class FriendListForm : Form
    {
        FriendListModel model;
        MenuForm _menuModel;
        public FriendListForm(FriendListModel friendListModel, MenuForm menuModel)
        {
            InitializeComponent();

            model = friendListModel;
            UpdateForm();
            this._menuModel = menuModel;
        }

        public void UpdateForm()
        {
            List<Friend> friendList = model.FriendsList;
            LoadListView(friendList);
        }

        private void LoadListView(List<Friend> listToShow)
        {
            FriendsListView.Items.Clear();
            var orderedList = listToShow.OrderBy(x => x.FullName);

            foreach (var item in listToShow)
            {
                string[] row = { item.FullName, DateTimeParser.ToStringWithFormat(item.BirthDate, "d"), item.Address, item.PhoneNumber, item.Remark };
                var listItem = new ListViewItem(row);
                FriendsListView.Items.Add(listItem);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (FriendsListView.SelectedItems != null)
            {
                DialogResult responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = FriendsListView.SelectedItems;
                    model.DeleteEntries(selectedItems);
                }

                List<Friend> updatedList = model.FriendsList;
                LoadListView(updatedList);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string queredParameter = QueredParameterCmbBx.Text;
            string query = SearchBox.Text;

            List<Friend> queredList = model.FindEntry(queredParameter, query);
            LoadListView(queredList);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateUpdateFriendForm createForm = new CreateUpdateFriendForm(this, model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = FriendsListView.SelectedItems[0];

            CreateUpdateFriendForm createForm = new CreateUpdateFriendForm(this, model, selectedItem);
            createForm.Show();
        }

        private void ShowUpcomingBirthDateCount()
        {
            MessageBox.Show($"Количество ближайших дней рождений: {model.UpcomingBirthDateCount}", "Предупреждение", MessageBoxButtons.OK);
        }

        private void FriendListForm_Load(object sender, EventArgs e)
        {
            if (model.UpcomingBirthDateCount != 0) ShowUpcomingBirthDateCount();
        }

        private void FriendListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menuModel.RefreshEntryCount();
        }
    }
}
