using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture] 
    class NoteTests
    {
        [Test(Description = "Позитивный тест геттера Tittle")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "Заголовок";
            var note = new Note("", "", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Title = expected;
            var actual = note.Title;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильный заголовок.");
        }

        [Test(Description = "Позитивный тест cеттера Tittle")]
        public void TestNoteTitleSet_CorrectValue()
        {
            var expected = "Заголовок_заметки";
            var note = new Note("Заголовок_заметки", "", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Title = expected;
            Assert.AreEqual(expected, note.Title, "Cеттер Title  устанавливает неправильное значение.");
        }

        [Test(Description = "Негативный тест cеттера Tittle, присваивание более 50 значений.")]
        public void TestNoteTitleSet_BadValue()
        {
            var wrongTitle = "123456789101112113142412412424214214214kkmkkmkmkkmkmkmkjnuniunu21421432435435423523432532534523523532532523";
            var note = new Note("", "", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            Assert.Throws<ArgumentException>( () => { note.Title = wrongTitle; },"-");
        }

        [Test(Description = "Позитивный тест cеттера NoteText")]
        public void TestNoteTextSet_CorrectValue()
        {
            var expected = "Заголовок_заметки";
            var note = new Note("Заголовок_заметки", "12313", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Text = expected;
            Assert.AreEqual(expected, note.Title, "Cеттер NoteText  устанавливает неправильное значение.");
        }

        [Test(Description = "Позитивный тест cеттера CreatedDate")]
        public void TestCreatedDateSet_CorrectValue()
        {
            var expected = "Заголовок_заметки";
            var note = new Note("Заголовок_заметки", "12313", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Text = expected;
            Assert.AreEqual(expected, note.Title, "Cеттер NoteText  устанавливает неправильное значение.");
        }

        [Test(Description = "Позитивный тест cеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var expected = NoteCategory.Work;
            var note = new Note("Заголовок_заметки", "12313", NoteCategory.Docs, DateTime.Now, DateTime.Now);
            note.Category = NoteCategory.Work;
            note.Category = expected;
            Assert.AreEqual(expected, note.Category, "Cеттер Category устанавливает неправильное значение.");
        }
    }
}
