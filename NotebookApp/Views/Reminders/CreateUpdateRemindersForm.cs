using NotebookApp.Models;
using System;
using System.Windows.Forms;

namespace NotebookApp.Views.Reminders
{
    public partial class CreateUpdateRemindersForm : Form
    {
        readonly RemindersModel _model;
        readonly RemindersForm _parentForm;
        readonly Reminder _oldEntry;
        public CreateUpdateRemindersForm(RemindersForm parentForm, RemindersModel model, ListViewItem oldEntry = default)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _model = model;

            if (oldEntry != default)
            {
                _oldEntry = new Reminder(oldEntry);
                EventDatePicker.Value = _oldEntry.EventDate;
                EventDescriptionTextBox.Text = _oldEntry.Description;
            }
        }

        private void CreateUpdateReminderBtn_Click(object sender, EventArgs e)
        {
            Reminder newEntry = new Reminder(
                eventDate: EventDatePicker.Value,
                description: EventDescriptionTextBox.Text
                );

            if (_oldEntry == default)
                _model.CreateEntry(newEntry);
            else
            {
                _model.UpdateEntry(_oldEntry, newEntry);
            }
            _parentForm.UpdateForm();
            Close();
        }


    }
}
