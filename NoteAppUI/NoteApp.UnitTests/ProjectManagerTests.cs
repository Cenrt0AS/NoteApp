using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;
using System.IO;
using System.Reflection;

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
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string testFilePath = $@"{path}\testSerialize.json";
            string expected = File.ReadAllText(testFilePath);
            Note note0 = new Note("Тест", "Тестик", NoteCategory.Docs, new DateTime(2019, 12, 12).Date, new DateTime(2019, 12, 12).Date);
            Note note1 = new Note("Машина", "Купить машину", NoteCategory.Home, new DateTime(2019, 11, 11).Date, new DateTime(2019, 11, 11).Date);
            Note note2 = new Note("Телефон", "Записать телефон", NoteCategory.HealthAndSport, new DateTime(2018, 12, 12).Date, new DateTime(2018, 12, 12).Date);
            Note note3 = new Note("Встреча", "Встретиться с человеком", NoteCategory.People, new DateTime(2019, 12, 12).Date, new DateTime(2019, 12, 12).Date);
              string filename = $@"{path}\testSerialize1.json";
            //for (int i=0; i<=3; i++)
            //  { 

            //  _testproject.dictionary.Add(i, note[0]);
            //  }
            _testproject.dictionary.Add(0, note0);
            _testproject.dictionary.Add(1, note1);
            _testproject.dictionary.Add(2, note2);
            _testproject.dictionary.Add(3, note3);
            ProjectManager.SaveToFile(_testproject, filename);
            string actual = File.ReadAllText(filename);
            Assert.AreEqual(expected, actual, "Файлы в сериализации различаются !");
        }

        [Test(Description = "Тест десериализации.")]
        public void DeserializeTest()
        {
            Note note0 = new Note("Тест", "Тестик", NoteCategory.Docs, new DateTime(2019, 12, 12).Date, new DateTime(2019, 12, 12).Date);
            Note note1 = new Note("Машина", "Купить машину", NoteCategory.Home, new DateTime(2019, 11, 11).Date, new DateTime(2019, 11, 11).Date);
            Note note2 = new Note("Телефон", "Записать телефон", NoteCategory.HealthAndSport, new DateTime(2018, 12, 12).Date, new DateTime(2018, 12, 12).Date);
            Note note3 = new Note("Встреча", "Встретиться с человеком", NoteCategory.People, new DateTime(2019, 12, 12).Date, new DateTime(2019, 12, 12).Date);
            _testproject2.dictionary.Add(0, note0);
            _testproject2.dictionary.Add(1, note1);
            _testproject2.dictionary.Add(2, note2);
            _testproject2.dictionary.Add(3, note3);
            Project expected = _testproject2;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string testFilePath = $@"{path}\testSerialize.json";
            Project preactual = ProjectManager.LoadFromFile(testFilePath);
            Project actual = preactual;
            int i = 0;
            foreach (KeyValuePair<int, Note> kvp in _testproject2.dictionary)
            { 
                Assert.AreEqual(expected.dictionary[i].Title, actual.dictionary[i].Title, 
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[i].Text, actual.dictionary[i].Text,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[i].Category, actual.dictionary[i].Category,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[i].DateofCreation, actual.dictionary[i].DateofCreation,
                "Значения в десериализации различаются !");
            Assert.AreEqual(expected.dictionary[i].LastmodDate, actual.dictionary[i].LastmodDate,
                "Значения в десериализации различаются !");
                i++;
            }
        }
    }
}
