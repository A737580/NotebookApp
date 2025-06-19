using NotebookApp.Interfaces;
using NotebookApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NotebookApp.Models
{
    public class FriendListModel : ICrudModel<Friend>
    {
        readonly FileService<Friend> _fileService;
        readonly List<Friend> _friendsList;
        readonly string _fileName = "friends.txt";

        int _upcomingBirthDateCount;

        public int UpcomingBirthDateCount => _upcomingBirthDateCount;
        public int GetFriendListEnryCount => _friendsList.Count;
        public List<Friend> FriendsList => _friendsList;
        
        public FriendListModel()
        {
            _fileService = new FileService<Friend>();
            _friendsList = _fileService.ReadFromFile(_fileName);
            CalculateUpcomingBirthDateCount();
        }

        public void CreateEntry(Friend newEntry)
        {
            _friendsList.Add(newEntry);
            _fileService.WriteToFile(_friendsList, _fileName);
        }

        public void UpdateEntry(Friend oldEntry, Friend modifiedEntry)
        {
            int entryIndex = _friendsList.IndexOf(oldEntry);
            _friendsList[entryIndex] = modifiedEntry;
            _fileService.WriteToFile(_friendsList, _fileName);
        }


        public List<Friend> FindEntry(string queredParameter, string query)
        {
            switch (queredParameter)
            {
                case "ФИО":
                    return _friendsList.Where(x => x.FullName.Contains(query)).ToList();
                case "Телефон":
                    return _friendsList.Where(x => x.PhoneNumber.Contains(query)).ToList();
                case "Адрес":
                    return _friendsList.Where(x => x.Address.Contains(query)).ToList();
                default:
                    return _friendsList;
            }
        }

        public void DeleteEntries(ICollection selectedEntries)
        {
            foreach (ListViewItem item in selectedEntries)
            {
                Friend friendToRemove = new Friend(item);
                _friendsList.Remove(friendToRemove);
                _fileService.WriteToFile(_friendsList, _fileName);
            }
        }

        private void CalculateUpcomingBirthDateCount() 
        {
            foreach (Friend eventEntry in FriendsList)
            {
                TimeSpan dateDiff = eventEntry.BirthDate.Date - DateTime.Now.Date;
                if (dateDiff > TimeSpan.Zero && dateDiff < TimeSpan.FromDays(5))
                {
                    _upcomingBirthDateCount++;
                }
            }
        }
    }
}
