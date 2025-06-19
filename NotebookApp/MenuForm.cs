using NotebookApp.Models;
using NotebookApp.Views.Diary;
using NotebookApp.Views.FriendsList;
using NotebookApp.Views.Reminders;
using System;
using System.Windows.Forms;
using System.Text;


namespace NotebookApp
{
    public partial class MenuForm : Form
    {
        DiaryModel diaryModel;
        FriendListModel friendListModel;
        RemindersModel remindersModel;
        public MenuForm()
        {
            InitializeComponent();
            diaryModel = new DiaryModel();
            friendListModel = new FriendListModel();
            remindersModel = new RemindersModel();
        }

        private void ToFriendsListBtn_Click(object sender, EventArgs e)
        {
            FriendListForm friendsListForm = new FriendListForm(friendListModel, this);
            friendsListForm.Show();
        }

        private void ToDiaryBtn_Click(object sender, EventArgs e)
        {
            DiaryForm diaryForm = new DiaryForm(diaryModel, this);
            diaryForm.Show();
        }

        private void ToRemindersBtn_Click(object sender, EventArgs e)
        {
            RemindersForm remindersForm = new RemindersForm(remindersModel, this);
            remindersForm.Show();
        }

        public void RefreshEntryCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"В списке знакомых {friendListModel.GetFriendListEnryCount} записей");
            sb.AppendLine($"В ежедневнике {diaryModel.GetDiaryEntryListCount} записей");
            sb.AppendLine($"В зписке напоминаний {remindersModel.GetEventsEnryCount} записей");
            ShowCountEntry.Text = sb.ToString();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            RefreshEntryCount();
        }

        private void MenuForm_Enter(object sender, EventArgs e)
        {

        }
    }
}
