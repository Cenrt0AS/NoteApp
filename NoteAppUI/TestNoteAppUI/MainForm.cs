using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNoteAppUI
{
    public partial class MainForm : Form

    {
        private Project _project;

        public MainForm()
        {
            InitializeComponent();
            LoadProject();
            TitleListboxAdd();
            //Передача полю Combobox формы MainForm значений из перечисление NoteCategory.
            ComoBoxCategory.DataSource = Enum.GetValues(typeof(NoteCategory));

            //Дополнительная реализация конец.
        }

        /// <summary>
        /// Функция для подсчёта записей в словаре.
        /// </summary>
        public int NewNumberOfRecords ()
        {
            int numberОfRecords = _project.dictionary.Count;
            return numberОfRecords;
        }

        /// <summary>
        /// Обработчик, заполняющий ListBox заголовками заметок из словаря.
        /// </summary>
        public void TitleListboxAdd()
        {
            TitleListbox.Items.Clear();
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary)
            {
                int n = 0;
                if (ComoBoxCategory.SelectedIndex == Convert.ToInt32(kvp.Value.Category))
                {
                    TitleListbox.Items.Insert(n, kvp.Value.Title);
                    n++;
                }
            }
        }
      
        /// <summary>
        /// Функция загрузки данных в программу.
        /// </summary>
        public void LoadProject()
        {
            try
            {
                string defaultPath = @"d:\\text.json";
                _project = ProjectManager.LoadFromFile(defaultPath);
            }
            catch
            {
                _project = new Project();
            }
        }

        /// <summary>
        /// Функция сохранения записей в файл Json.
        /// </summary>
        public void SaveProject()
        {
            ProjectManager.SaveToFile(_project, @"d:\\text.json");
        }

        /// <summary>
        /// Верхнее меню-> Добавление.
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteManage form = new NoteManage(_project);
           
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.dictionary.Add(AvailableKey(), form.note);
                TitleListboxAdd();
                 SaveProject();
            }           
        }

        /// <summary>
        /// Верхнее меню-> Редактирование.
        /// </summary>
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteManage form = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleListbox.SelectedIndex;
            // Показ уже имеющихся данных в окне редактирования.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string NoteValue = TitleListbox.SelectedItem.ToString();
                int OperatedKey = GetKeyByValue(NoteValue);
                form.titleTBox.Text = _project.dictionary[OperatedKey].Title;
                form.ComboBoxCategory1.SelectedIndex = Convert.ToInt32(_project.dictionary[OperatedKey].Category);
                form.textBox1.Text = _project.dictionary[OperatedKey].NoteText;
                form.dateTimePicker1.Value = _project.dictionary[OperatedKey].DateofCreation;
                form.dateTimePicker2.Value = _project.dictionary[OperatedKey].LastmodDate;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime KeepDate = _project.dictionary[OperatedKey].DateofCreation;
                    form.note.DateofCreation = KeepDate;
                    _project.dictionary[OperatedKey] =(form.note);
                    SaveProject();
                    TitleListbox.SelectedItem = (_project.dictionary[OperatedKey].Title);
                    TitleListboxAdd();
                }
            }
        }

        /// <summary>
        /// Кнопка добавление.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NoteManage form = new NoteManage(_project);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.dictionary.Add(NewNumberOfRecords(), form.note);
                TitleListboxAdd();
                SaveProject();
            }
        }

        /// <summary>
        /// Кнопка редактирование.
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage form = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleListbox.SelectedIndex;
            // Показ уже имеющихся данных в окне редактирования.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string NoteValue = TitleListbox.SelectedItem.ToString();
                int OperatedKey = GetKeyByValue(NoteValue);
                form.titleTBox.Text = _project.dictionary[OperatedKey].Title;
                form.ComboBoxCategory1.SelectedIndex = Convert.ToInt32(_project.dictionary[OperatedKey].Category);
                form.textBox1.Text = _project.dictionary[OperatedKey].NoteText;
                form.dateTimePicker1.Value = _project.dictionary[OperatedKey].DateofCreation;
                form.dateTimePicker2.Value = _project.dictionary[OperatedKey].LastmodDate;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime KeepDate = _project.dictionary[OperatedKey].DateofCreation;
                    form.note.DateofCreation = KeepDate;
                    _project.dictionary[OperatedKey] = (form.note);
                    SaveProject();
                    TitleListbox.SelectedItem = (_project.dictionary[OperatedKey].Title);
                    TitleListboxAdd();
                }
            }
        }
        /// <summary>
        /// Кнопка удаление.
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Проверка выборки.
            int selectedID = TitleListbox.SelectedIndex;
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                int operatedKey = GetKeyByValue(TitleListbox.SelectedItem.ToString());
                _project.dictionary.Remove(operatedKey);
                TitleListboxAdd();
                SaveProject();
            }
        }

        /// <summary>
        /// Обработчик событий при закрытии формы MainForm.
        /// </summary>
        private void MainForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            SaveProject();
        }

        /// <summary>
        /// Верхнее меню-> Удаление.
        /// </summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверка выборки.
            int selectedID = TitleListbox.SelectedIndex;
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                int operatedKey = GetKeyByValue(TitleListbox.SelectedItem.ToString());
                _project.dictionary.Remove(operatedKey);
                TitleListboxAdd();
                SaveProject();
            }
        }

        /// <summary>
        /// Обработчик который выводит данные заметки на компоненты формы..
        /// </summary>
        private void TitleLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TitleListbox.SelectedIndex != -1)
            {
                int selected = GetKeyByValue(TitleListbox.SelectedItem.ToString());
                Titlelabel.Text = TitleListbox.SelectedItem.ToString();
                string CategoryText = "Note not selected";
                CategoryText = _project.dictionary[selected].Category.ToString();
                CategoryLabel.Text = CategoryText;
                CategoryLabel.Visible = true;
                textBox.Text = _project.dictionary[selected].NoteText;
                dateTimePicker1.Value = _project.dictionary[selected].DateofCreation;
                dateTimePicker2.Value = _project.dictionary[selected].LastmodDate;
            }
            Titlelabel.Visible = true;
        }
        /// <summary>
        /// Верхнее меню ->Help->About
        /// </summary>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        /// <summary>
        /// Верхнее меню ->File->Exit
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            Application.Exit();
        }

        /// <summary>
        /// Выбор категории из ComboBox, MainForm
        /// </summary>
        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleListboxAdd();
        }

        /// <summary>
        /// Функция которая находить ключ по значению. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Возвращает индекс ключа</returns>
        public int GetKeyByValue(string value)
        {
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary) 
            {
                if (kvp.Value.Title.Equals(value))
                    return kvp.Key;
            }
        
            return -1;
        }
        /// <summary>
        /// Функция, которая проверяет доступность ключа в словаре.
        /// </summary>
        /// <returns>Возвращает индекс доступного ключа.</returns>
        public int AvailableKey ()
        {
            int i = 0;
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary)
            {
                if (kvp.Key == i)
                    i++;
                else return i;
            }
            return -1;
        }
    }
}
