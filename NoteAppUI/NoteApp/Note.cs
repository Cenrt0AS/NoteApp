using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки , содержащий в себе поля для заметок. 
    /// </summary>
    public class Note
    {
        private NoteCategory _category;
        private string _title;
        private string NoteText { get; set; } = "Текст заметки";
        public DateTime DateofCreation { get; set; } = DateTime.Now;
        public DateTime LastmodDate { get; set; } = DateTime.Now;

        public Note(string title, string noteText, NoteCategory category, DateTime dateofCreation, DateTime lastmodDate)
        {
            Title = _title;
            NoteText = noteText;
            category = _category;
            DateofCreation = dateofCreation;
            LastmodDate = lastmodDate;
        }
        public string Title 
        {
            get
            {
                return _title;
            }

            set 
            {
                if (value.Length > 50) // Тут ошибка
                    _title = value;
            }

        }
    }
}
    
