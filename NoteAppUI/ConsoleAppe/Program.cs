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
            Note note= new Dictionary(1,"tittel","text",NoteCategory.Finance,DateTime.Now,DateTime.Now);

            SaveToFile(note);


           // LoadFromFile("test.txt");

            
            Console.WriteLine(note.Title + note.DateofCreation);       
            Console.ReadKey();
            
        }
    }
}
