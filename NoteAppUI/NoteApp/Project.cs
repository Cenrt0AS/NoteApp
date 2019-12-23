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

        public Dictionary<int, Note> dictionary = new Dictionary<int, Note>();
        public Note CurrentNote;

        /// <summary>
        /// percvaya realizacya
        /// </summary>
        /// <returns></returns>
        public Dictionary<int,Note> SortedDictionary()
        {
            var newDictionary = from note in dictionary
                                orderby note.Value.LastmodDate ascending
                                select note;

            return newDictionary.ToDictionary( pair => pair.Key, pair => pair.Value );
        }

        /// <summary>
        /// vtoraya relizacya
        /// </summary>
        public Dictionary<int,Note> SortedDictionary(NoteCategory category)
        {
            var newDictionary = from note in dictionary
                                where note.Value.Category == category
                                orderby note.Value.LastmodDate ascending
                                select note;

            return newDictionary.ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
