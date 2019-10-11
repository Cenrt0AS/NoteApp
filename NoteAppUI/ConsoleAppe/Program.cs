using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleAppe
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note= new Note("tittel","text",noteCategory.finance,DateTime.Now,DateTime.Now);
            //Запись в JSON файл 
            File.WriteAllText("note.json", JsonConvert.SerializeObject(note));

            // Чтение из JSON файла
            //File.Exists("note.json") ? JsonConvert.DeserializeObject<Note> : new Note()  
            Console.WriteLine(note.Category+ note.DateofCreation);       
            Console.ReadKey();
            //serializer.Serialize(writer, note);
            //  SaveToFile()
        }
    }
}
