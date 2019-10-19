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
            Note note = new Note("tittel", "text", NoteCategory.Finance, DateTime.Now, DateTime.Now);
            Note note2;           

            ProjectManager.SaveToFile(note,@"d:\test.txt");

            note2 = ProjectManager.LoadFromFile(@"d:\test.txt");


            Project dict = new Project();
            dict.dictionary.Add(1, note);

            Console.WriteLine(note2.Title + note2.DateofCreation);       
            Console.ReadKey();
            
        }
    }
}
