using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс,содержащий в себе структуру данных словарь.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Словарь, который содержит в себе ключ и значение из полей Note.
        /// </summary>

        //TODO: Можно еще хранить дополнительное поле CurrentNote.
        public Dictionary<int, Note> dictionary = new Dictionary<int, Note>();
        public Note CurrentNote;

    }
}
