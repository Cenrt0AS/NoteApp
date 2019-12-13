using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, содержащий в себе поля для заметок. 
    /// </summary>
    public class Note
    {
        /// <summary>
        /// 
        /// </summary>
        public NoteCategory Category;

        /// <summary>
        /// 
        /// </summary>
        private string _title;

        /// <summary>
        /// 
        /// </summary>
        public string NoteText { get; set; } = "Текст заметки";
        public DateTime DateofCreation { get; set; } = DateTime.Now;
        public DateTime LastmodDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Конструктор класса Note.
        /// </summary>
        /// <param name="title"> Поле Заголовок заметки</param>
        /// <param name="noteText"> Поле Текст заметки</param>
        /// <param name="category"> Поле Категория заметки</param>
        /// <param name="dateofCreation"> Поле Дата создания заметки</param>
        /// <param name="lastmodDate"> Поле Дата изменения заметки</param>
        public Note(string title, string noteText, NoteCategory category, DateTime dateofCreation, DateTime lastmodDate)
        {
            Title = title; 
            NoteText = noteText;
            Category = category;
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
                if (value.Length < 50)
                {
                    _title = value;
                    LastmodDate = DateTime.Now;
                }
                else
                    throw new ArgumentException();
            }

        }
    }
}
    
