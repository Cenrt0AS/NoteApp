using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;
using System.IO;

namespace NoteApp.UnitTests
{
    [TestFixture] // Для того чтобы VS и adapter могли отличить простой класс от класса тестов.
    class ProjectManagerTests
    {

        private Project _testproject = new Project();
        private Project _testproject2 = new Project();

        [Test(Description = "Тест сериализации.")]
        public void SerializeTest()
        {
            string testFilePath = @"testSerialize.json";
            string expected = File.ReadAllText(testFilePath);
            Note note = new Note("Тест", "Тестик", NoteCategory.Docs, new DateTime(2019, 12, 12), new DateTime(2019, 12, 12));
            //string defaultPath = Environment.CurrentDirectory;
            string filename = "testSerialize1.json";
            _testproject.dictionary.Add(0, note);
            ProjectManager.SaveToFile(_testproject, filename);
            string actual = File.ReadAllText(filename);
            Assert.AreEqual(expected, actual, "Файлы в сериализации различаются !");
        }

        [Test(Description = "Тест десериализации.")]
        public void DeserializeTest()
        {
            Note note = new Note("Тест", "Тестик", NoteCategory.Docs, new DateTime(2019, 12, 12), new DateTime(2019, 12, 12));
            _testproject2.dictionary.Add(0, note);
            Project expected = _testproject2;
            string filename = @"testSerialize.json";
            Project preactual = ProjectManager.LoadFromFile(filename);
            Project actual = preactual;
    
            //TODO: выасыв
            Assert.AreEqual(expected.dictionary[0].Title, actual.dictionary[0].Title, 
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[0].NoteText, actual.dictionary[0].NoteText,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[0].Category, actual.dictionary[0].Category,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[0].DateofCreation, actual.dictionary[0].DateofCreation,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[0].LastmodDate, actual.dictionary[0].LastmodDate,
                "Значения в десериализации различаются !");
        }
    }
}
