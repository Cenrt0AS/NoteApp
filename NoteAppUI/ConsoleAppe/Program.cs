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
            Note note = new Note("imya", "text", NoteCategory.Finance, DateTime.Now, DateTime.Now);
            Note note1 = new Note("imya1", "text1", NoteCategory.Work, DateTime.Now, DateTime.Now);
            Note note2 = new Note("imya2", "text2", NoteCategory.HealthAndSport, DateTime.Now, DateTime.Now);
            Project pClass = new Project();

            pClass.dictionary.Add(0, note);
            pClass.dictionary.Add(1, note1);
            pClass.dictionary.Add(2, note2);

            ProjectManager.SaveToFile(pClass, @"d:\\text.json");

            Project pClass2 = new Project();

            
            Console.WriteLine(ProjectManager.LoadFromFile(@"d:\\text.json").dictionary[1].Title);
           


          // Project dict = new Project();
          // dict.dictionary.Add(1, note);

          // Console.WriteLine(note2.Title + note2.DateofCreation);       
            Console.ReadKey();
            
        }
    }
}
