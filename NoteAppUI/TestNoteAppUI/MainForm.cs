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
            ProjectLoading();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex + 1;
            
            Titlelabel.Text = listBox1.SelectedItem.ToString();
            Titlelabel.Visible = true;
            // Преобразование типов для вывода на listbox.
            string CategoryText = _project.dictionary[selectedIndex].Category.ToString();
            CategoryLabel.Text = CategoryText;
            CategoryLabel.Visible = true;
           // dateTimePicker1 = _project.dictionary[selectedIndex].DateofCreation;
            //dateTimePicker2.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Реализовать подсчёт записей в словаре.
            _project.dictionary.Count{ get; };
            string noteItem = _project.dictionary[1].Title;
            listBox1.Items.Insert(0, _project.dictionary[1].Title);
            listBox2.Items.Insert(0, _project.dictionary[1].NoteText);
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            cbCategory.DataSource = Enum.GetValues(typeof(NoteCategory));

        }

        public void ProjectLoading()
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage();
            frm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NoteManage frm = new NoteManage();
            frm.Show();
        }
    }
}
