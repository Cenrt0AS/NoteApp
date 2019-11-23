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

            //Дополнительная инициализация начало.

            //Подсчёт записей в словаре.
            int numberОfRecords = _project.dictionary.Count;

            // string noteItem = _project.dictionary[1].Title;
            for (int i = 0; i != numberОfRecords; i++)
            {
                TitleLb.Items.Insert(i, _project.dictionary[i].Title);
                //  textBox.Text = _project.dictionary[1].NoteText;
            }
            //  TitleLb.Items.Insert(0, _project.dictionary[1].Title);
            // textBox.Text = _project.dictionary[1].NoteText;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            cbCategory.DataSource = Enum.GetValues(typeof(NoteCategory));

            //Дополнительная реализация конец.



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            // dateTimePicker1 = _project.dictionary[selectedIndex].DateofCreation;
            //dateTimePicker2.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadProject();

            ////Дополнительная инициализация начало.

            ////Подсчёт записей в словаре.
            //int numberОfRecords = _project.dictionary.Count;

            //// string noteItem = _project.dictionary[1].Title;
            //for (int i = 0; i != numberОfRecords; i++)
            //{
            //    TitleLb.Items.Insert(i, _project.dictionary[i].Title);
            //    //  textBox.Text = _project.dictionary[1].NoteText;
            //}
            ////  TitleLb.Items.Insert(0, _project.dictionary[1].Title);
            //// textBox.Text = _project.dictionary[1].NoteText;
            //dateTimePicker1.Visible = true;
            //dateTimePicker2.Visible = true;
            //cbCategory.DataSource = Enum.GetValues(typeof(NoteCategory));


        }

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

        public void SaveProject()
        {
            ProjectManager.SaveToFile(_project, @"d:\\text.json");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project,1);
            frm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project,2);
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project,1);
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage(_project,2);
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _project.dictionary.Remove(TitleLb.SelectedIndex);
            TitleLb.Items.RemoveAt(TitleLb.SelectedIndex);
            TitleLb.SelectedIndex = -1;
        }
        private void MainForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            SaveProject();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _project.dictionary.Remove(TitleLb.SelectedIndex);
        }


        //TODO:Update data???
    }
}
