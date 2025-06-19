using System.Collections;
using System.Collections.Generic;

namespace NotebookApp.Interfaces
{
    internal interface ICrudModel<T> // Crud = Create-Read-Update-Delete
    {
        void CreateEntry(T newEntry);
        void UpdateEntry(T oldEntry, T modifiedEntry);
        void DeleteEntries(ICollection selectedEntries);
        List<T> FindEntry(string queredParameter, string query);
    }
}
