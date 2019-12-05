using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture] // Для того чтобы VS и adapter могли отличить простой класс от класса тестов.
    class ProjectTest
    {
        /// <summary>
        /// Unit тест для проверки геттера title в классе Note.
        /// </summary>
        /// 
        public Note note; //?
        public void TestTitleGet_CorrectValue()
        {

            var expected = "Заголовок";
            var note = new Note();
            note.Title = expected;
            var actual = note.Title;

            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильный заголовок."); 
        }

    }
}
