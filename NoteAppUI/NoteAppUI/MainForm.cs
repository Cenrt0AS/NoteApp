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
        // создаем новый экземпляр projectManager
        private Project _project;
        
        public MainForm()
        {           
            InitializeComponent();
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
        private void ProjectLoad()
        {   // try
            // _project.dictionary = ProjectManager.LoadFromFile();

            // catch
            // _project = new Project();
            
        }

        //
        private void ProjectSave()
        {
            //ProjectManager.SaveToFile();
        }

        //TODO: Вывести сохраненные файлы
        private void DictionaryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show(ProjectManager.LoADfROMfILE("sdfsdfs.json");
            //foreach(note in project.disctionary){show(note.name)};
        }
    }
}
