using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note
    {
        protected String Title { get; set; } = "Заголовок";
        
        protected String Category
        {
            get
            {
                return Category;
            }

            set
            {

                Category = "Заголовок";
            }
        }
        protected String NoteText { get; set; } = "Текст заметки";
        private DateTime DateofCreation { get; set; } = DateTime.Now;
        private DateTime LastmodDate { get; set; } = DateTime.Now;

            //public string Title { get; set; } // Автоматический свойства
        
        //Конструктор класса
        public Note (String Title, String Text, 
            String NoteText, DateTime DateofCreation, DateTime LastmodDate)
        {
            Title = title;

        }
    }
}
