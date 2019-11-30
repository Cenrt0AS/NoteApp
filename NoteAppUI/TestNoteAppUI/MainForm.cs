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
            // string noteItem = _project.dictionary[1].Title;
            for (int i = 0; i != _project.dictionary.Count; i++)
            {
                TitleLb.Items.Insert(i, _project.dictionary[i].Title);
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
                _project.dictionary.Add(NewNumberOfRecords(), frm.note);
                // TitleLBAdd();
                TitleLb.Items.Insert(_project.dictionary.Count -1, _project.dictionary[_project.dictionary.Count -1 ].Title);
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
            //
            // NoteManage frm = new NoteManage(_project, 1);
            //TODO: Еще протестировать редактирование.
            // Показ уже имеющихся данных в окне редактирования.
            //TODO: Добавить проверку на выбранную запись.
            if (selectedID < 0)
            {
                MessageBox.Show("Выберите пожайлуста заметку!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            { 
                frm.titleTBox.Text = _project.dictionary[selectedID].Title;
                //frm.cbCategory1.SelectedIndex = _project.dictionary[selectedID].Category;
                frm.textBox1.Text = _project.dictionary[selectedID].NoteText;
                frm.dateTimePicker1.Value = _project.dictionary[selectedID].DateofCreation;
                frm.dateTimePicker2.Value = _project.dictionary[selectedID].LastmodDate;
                if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _project.dictionary[selectedID] =(frm.note);
                        // TitleLBAdd();
                        SaveProject();
                        TitleLb.SelectedItem = (_project.dictionary[selectedID].Title);
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
            frm.Show();
        }
        /// <summary>
        /// Кнопка редактирование.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project);
            frm.Show();
        }
        /// <summary>
        /// Кнопка удаление.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _project.dictionary.Remove(TitleLb.SelectedIndex);
            TitleLb.Items.RemoveAt(TitleLb.SelectedIndex);
            TitleLb.SelectedIndex = -1;
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
            _project.dictionary.Remove(TitleLb.SelectedIndex);
        }
        /// <summary>
        /// Обработчик который выводит данные заметки на компоненты формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = TitleLb.SelectedIndex;
            if (TitleLb.SelectedIndex != -1)
                Titlelabel.Text = TitleLb.SelectedItem.ToString();

            Titlelabel.Visible = true;
            // Преобразование типов для вывода на listbox.
            string CategoryText = "Note not selected";
            if (TitleLb.SelectedIndex != -1)
                CategoryText = _project.dictionary[selectedIndex].Category.ToString();

            CategoryLabel.Text = CategoryText;
            CategoryLabel.Visible = true;
            textBox.Text = _project.dictionary[selectedIndex].NoteText;
            dateTimePicker1.Value = _project.dictionary[selectedIndex].DateofCreation;
            dateTimePicker2.Value = _project.dictionary[selectedIndex].LastmodDate;
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
    }
}
