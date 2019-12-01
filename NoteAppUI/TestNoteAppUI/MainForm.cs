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
        /// <returns>Возвращает числовое значение.</returns>
        public int NewNumberOfRecords ()
        {
            int numberОfRecords = _project.dictionary.Count;
            return numberОfRecords;
        }

        /// <summary>
        /// Обработчик, заполняющий ListBox заголовками заметок из словаря.
        /// </summary>
        public void TitleLBAdd()
        {
            //TODO: Реализовать фильтр по категориям.
            // string noteItem = _project.dictionary[1].Title;
            TitleLb.Items.Clear();
            //for (int i = 0; i != _project.dictionary.Count; i++)
            //{
            //    int n = 0; //Вспомогательная переменная описывающая индекс в позиции ListBox.
            //    if (cbCategory.SelectedIndex == Convert.ToInt32(_project.dictionary[i].Category))
            //    { 
            //        TitleLb.Items.Insert(n, _project.dictionary[i].Title);
            //        n++;
            //    }
            //    //  textBox.Text = _project.dictionary[1].NoteText;
            //}
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary)
            {
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleLb.SelectedIndex;
            //TODO: Еще протестировать редактирование.
            // Показ уже имеющихся данных в окне редактирования.
            //TODO: Добавить проверку на выбранную запись.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string NoteValue = TitleLb.SelectedItem.ToString() ;
               int OperatedKey = GetKeyByValue(NoteValue);
                frm.titleTBox.Text = _project.dictionary[OperatedKey].Title;
                frm.cbCategory1.SelectedIndex = Convert.ToInt32(_project.dictionary[OperatedKey].Category);
                frm.textBox1.Text = _project.dictionary[OperatedKey].NoteText;
                //TODO: Правильная работа Date.
                frm.dateTimePicker1.Value = _project.dictionary[OperatedKey].DateofCreation;
                frm.dateTimePicker2.Value = _project.dictionary[OperatedKey].LastmodDate;
                if (frm.ShowDialog() == DialogResult.OK)
                    {
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);
            // Переменная для хранения ключа редактирования записи.
            int selectedID = TitleLb.SelectedIndex;
            //TODO: Еще протестировать редактирование.
            // Показ уже имеющихся данных в окне редактирования.
            //TODO: Добавить проверку на выбранную запись.
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int operatedKey = GetKeyByValue(TitleLb.SelectedItem.ToString());
            _project.dictionary.Remove(operatedKey);
            //TitleLb.Items.RemoveAt(TitleLb.SelectedIndex);
            //TitleLb.SelectedIndex = -1;
            TitleLBAdd();
        }
        /// <summary>
        /// Обработчик событий при закрытии формы MainForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            SaveProject();
        }
        /// <summary>
        /// Верхнее меню-> Удаление.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int operatedKey = GetKeyByValue(TitleLb.SelectedItem.ToString());
            _project.dictionary.Remove(operatedKey);
            //TitleLb.Items.RemoveAt(TitleLb.SelectedIndex);
            //TitleLb.SelectedIndex = -1;
            TitleLBAdd();
        }
        /// <summary>
        /// Обработчик который выводит данные заметки на компоненты формы..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleLb_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  int selectedIndex = TitleLb.SelectedIndex;
   
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
            // Преобразование типов для вывода на listbox.
            //string CategoryText = "Note not selected";
            //if (TitleLb.SelectedIndex != -1)
            // { 
            //    CategoryText = _project.dictionary[selectedIndex].Category.ToString();
            //    CategoryLabel.Text = CategoryText;
            //    CategoryLabel.Visible = true;
            //    textBox.Text = _project.dictionary[selectedIndex].NoteText;
            //    dateTimePicker1.Value = _project.dictionary[selectedIndex].DateofCreation;
            //    dateTimePicker2.Value = _project.dictionary[selectedIndex].LastmodDate;
            //}
        }


        //TODO:Update data???
        /// <summary>
        /// Верхнее меню ->Help->About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        /// <summary>
        /// Верхнее меню ->File->Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            Application.Exit();
        }

        /// <summary>
        /// Выбор категории из ComboBox, MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleLBAdd();
        }

        //TODO: Реализовать проверку вводимых данных где нибуть на IsNullOrEmpty().
        //
        public int GetKeyByValue(string value)
        {
            foreach (KeyValuePair<int, Note> kvp in _project.dictionary)
            //{
            //for (int i = 0; i != _project.dictionary.Count; i++)
            {
                if (kvp.Value.Title.Equals(value))
                    //return _project.dictionary[i].Key;
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
