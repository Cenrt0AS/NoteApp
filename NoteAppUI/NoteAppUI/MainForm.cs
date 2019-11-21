using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteApp
{
    public partial class MainForm : Form
    {
        // создаем новый экземпляр project
        private Project _project;
        
        public MainForm()
        {
            InitializeComponent();
            ProjectLoading();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close(); // Закрывает форму?
            Application.Exit();
        }

        // (десериализация) загружает словарь заметок, добавить в _project.dictionary
        public void ProjectLoading()
        {    //try
            //{
                string defaultPath = @"d:\text.json";
                
                _project = ProjectManager.LoadFromFile(defaultPath);
            //}
            // catch 
            //{
            //     _project = new Project();
            //}
        }

        //
        private void ProjectSave()
        {
           // ProjectManager.SaveToFile();
        }

        //TODO: Вывести сохраненные файлы
        private void DictionaryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string noteItem = _project.dictionary[1].Title;
            DictionaryListBox.Items.Insert(0, "vanya");
            // show(ProjectManager.LoADfROMfILE("sdfsdfs.json");
            //foreach(note in project.dictionary){show(note.name)};
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {

        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteManageForm frm = new NoteManageForm();
            frm.Show();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteManageForm frm = new NoteManageForm();
            frm.Show();
        }

        public void Refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
