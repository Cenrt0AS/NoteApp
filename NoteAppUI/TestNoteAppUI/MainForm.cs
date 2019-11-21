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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string noteItem = _project.dictionary[1].Title;
            listBox1.Items.Insert(0, _project.dictionary[1].Title);
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
    }
}
