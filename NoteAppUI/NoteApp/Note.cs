using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки , содержащий в себе поля для заметок. 
    /// </summary>
    public class Note
    {
        private string _category;
        private string Title { get; set; } = "Заголовок";
        private string NoteText { get; set; } = "Текст заметки";
        public DateTime DateofCreation { get; set; } = DateTime.Now;
        public DateTime LastmodDate { get; set; } = DateTime.Now;

        public Note(string title, string noteText, string category, DateTime dateofCreation, DateTime lastmodDate)
        {
            Title = title;
            NoteText = noteText;
            Category = category;
            DateofCreation = dateofCreation;
            LastmodDate = lastmodDate;
        }

        public string Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
                
            }
        }
        

        //public string Title { get; set; } // Автоматический свойства

        // Конструктор класса
        

    }
}
