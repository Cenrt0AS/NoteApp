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
        [Test(Description = "Тест сериализации.")]
        public void SerializeTest()
        {
            // string testFilePath = Environment.CurrentDirectory + "testSerialize.json";
            //string testFilePath = Path.Combine(System.Environment.CurrentDirectory, @"\testSerialize.json");
            string testFilePath = @"C:\Users\Admin\Source\Repos\YalovskiyV\NoteApp\NoteAppUI\NoteApp.UnitTests\testSerialize.json";
           // DateTime createdDate = new DateTime(2019, 12, 12, 18, 20, 37.0369362);
            //DateTime modifiedDate = new DateTime(2015, 7, 20, 18, 30, 25);
            DateTime createdDate = new DateTime(2019,12,12);
            DateTime modifiedDate = new DateTime(2019,12,12);
            var date1 = createdDate.Date;
            var date2 = modifiedDate.Date;  
            var expected = File.ReadAllText(testFilePath);
            var note = new Note("Тест", "Тестик", NoteCategory.Docs,date1, date2);
            //string defaultPath = Environment.CurrentDirectory;
            string filename = "testSerialize1.json";
            //_testproject.dictionary.Add(0, note);
            ProjectManager.SaveToFile(_testproject, filename);
            var actual = File.ReadAllText("testSerialize1.json");
            Assert.AreEqual(expected, actual, "Файлы в сериализации различаются !");
        }

        [Test(Description = "Тест десериализации.")]
        public void DeserializeTest()
        {
            var note = new Note("Тест", "Тестик", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            _testproject.dictionary.Add(0, note);
            var expected = _testproject;
            string filename = @"C:\Users\Admin\Source\Repos\YalovskiyV\NoteApp\NoteAppUI\NoteApp.UnitTests\testSerialize.json";
            var preactual = ProjectManager.LoadFromFile(filename);
            var actual = preactual;
            Assert.AreEqual(expected, actual, "Значения в десериализации различаются !");
        }

    }
}
