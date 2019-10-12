using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var note= new Dictionary<int,Note>
            {
                {1, new Note("tittel", "text", NoteCategory.Finance, DateTime.Now, DateTime.Now ) }
            };
            ProjectManager.SaveToFile(note);
            ProjectManager.LoadFromFile("test.txt");

            
            Console.WriteLine(note.Title + note.DateofCreation);       
            Console.ReadKey();
            
        }
    }
}
