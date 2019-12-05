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
            TitleLBAdd();
            //Передача полю Combobox формы MainForm значений из перечисление NoteCategory.
            cbCategory.DataSource = Enum.GetValues(typeof(NoteCategory));

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
        //TODO: titeleLB&???
        public void TitleLBAdd()
        {
            TitleLb.Items.Clear();
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary)
            {
                //TODO: n всегда равен 1 или 0
                int n = 0;
                if (cbCategory.SelectedIndex == Convert.ToInt32(kvp.Value.Category))
                {
                    TitleLb.Items.Insert(n, kvp.Value.Title);
                    n++;
                }
                //  textBox.Text = _project.dictionary[1].NoteText;
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
            // TODO: frm???
            NoteManage frm = new NoteManage(_project);
           
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _project.dictionary.Add(AvailableKey(), frm.note);
                 TitleLBAdd();
                 SaveProject();
            }           
        }

        /// <summary>
        /// Верхнее меню-> Редактирование.
        /// </summary>
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleLb.SelectedIndex;
            // Показ уже имеющихся данных в окне редактирования.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string NoteValue = TitleLb.SelectedItem.ToString();
                int OperatedKey = GetKeyByValue(NoteValue);
                frm.titleTBox.Text = _project.dictionary[OperatedKey].Title;
                frm.cbCategory1.SelectedIndex = Convert.ToInt32(_project.dictionary[OperatedKey].Category);
                frm.textBox1.Text = _project.dictionary[OperatedKey].NoteText;
                //TODO: Правильная работа Date.
                frm.dateTimePicker1.Value = _project.dictionary[OperatedKey].DateofCreation;
                frm.dateTimePicker2.Value = _project.dictionary[OperatedKey].LastmodDate;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DateTime KeepDate = _project.dictionary[OperatedKey].DateofCreation;
                    frm.note.DateofCreation = KeepDate;
                    _project.dictionary[OperatedKey] =(frm.note);
                    SaveProject();
                    TitleLb.SelectedItem = (_project.dictionary[OperatedKey].Title);
                    TitleLBAdd();
                }
            }
        }

        /// <summary>
        /// Кнопка добавление.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _project.dictionary.Add(NewNumberOfRecords(), frm.note);
                TitleLBAdd();
                SaveProject();
            }
        }

        /// <summary>
        /// Кнопка редактирование.
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleLb.SelectedIndex;
            // Показ уже имеющихся данных в окне редактирования.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string NoteValue = TitleLb.SelectedItem.ToString();
                int OperatedKey = GetKeyByValue(NoteValue);
                frm.titleTBox.Text = _project.dictionary[OperatedKey].Title;
                frm.cbCategory1.SelectedIndex = Convert.ToInt32(_project.dictionary[OperatedKey].Category);
                frm.textBox1.Text = _project.dictionary[OperatedKey].NoteText;
                //TODO: Правильная работа Date.
                frm.dateTimePicker1.Value = _project.dictionary[OperatedKey].DateofCreation;
                frm.dateTimePicker2.Value = _project.dictionary[OperatedKey].LastmodDate;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DateTime KeepDate = _project.dictionary[OperatedKey].DateofCreation;
                    frm.note.DateofCreation = KeepDate;
                    _project.dictionary[OperatedKey] = (frm.note);
                    SaveProject();
                    TitleLb.SelectedItem = (_project.dictionary[OperatedKey].Title);
                    TitleLBAdd();
                }
            }
        }
        /// <summary>
        /// Кнопка удаление.
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Проверка выборки.
            int selectedID = TitleLb.SelectedIndex;
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                int operatedKey = GetKeyByValue(TitleLb.SelectedItem.ToString());
                _project.dictionary.Remove(operatedKey);
                TitleLBAdd();
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
            int selectedID = TitleLb.SelectedIndex;
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                int operatedKey = GetKeyByValue(TitleLb.SelectedItem.ToString());
                _project.dictionary.Remove(operatedKey);
                TitleLBAdd();
                SaveProject();
            }
        }

        /// <summary>
        /// Обработчик который выводит данные заметки на компоненты формы..
        /// </summary>
        private void TitleLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TitleLb.SelectedIndex != -1)
            {
                int selected = GetKeyByValue(TitleLb.SelectedItem.ToString());
                Titlelabel.Text = TitleLb.SelectedItem.ToString();
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
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        /// <summary>
        /// Верхнее меню ->File->Exit
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            Application.Exit();
        }

        /// <summary>
        /// Выбор категории из ComboBox, MainForm
        /// </summary>
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleLBAdd();
        }

        public int GetKeyByValue(string value)
        {
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary) 
            {
                if (kvp.Value.Title.Equals(value))
                    return kvp.Key;
            }
        
            return -1;
        }

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
