using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture] // Для того чтобы VS и adapter могли отличить простой класс от класса тестов.
    class NoteTests
    {
        /// <summary>
        /// Unit тест для проверки геттера title в классе Note.
        /// </summary>
        /// 
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestTitleGet_CorrectValue()
        {

            var expected = "Заголовок";
            var note = new Note("", "", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Title = expected;
            var actual = note.Title;

            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильный заголовок.");
        }
    }
}
