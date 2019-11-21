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
    public partial class Form1 : Form

    {
        private Project _project;
        public Form1()
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
            string defaultPath = @"d:\\text.json";

            _project = ProjectManager.LoadFromFile(defaultPath);
            
        }

    }
}
