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

namespace TestNoteAppUI
{
    public partial class NoteManage : Form
    {

        public Note note;
        //TODO: На основе этого Note сделать проверку на Emty и выбрать действие для него.
        // При Edit передаю данные в этот note.
        public NoteManage(Project dictionary)
        {
            InitializeComponent();
            cbCategory1.DataSource = Enum.GetValues(typeof(NoteCategory));

           
        }

        

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //TODO: Добавление
            int Category = cbCategory1.SelectedIndex;

            note = new Note(titleTBox.Text, textBox1.Text, (NoteCategory)Category, DateTime.Now, DateTime.Now);

            //TODO: Редактирование

            //TODO: добавить сюда сохранение.                   
            DialogResult = DialogResult.OK;
        }
    }
}
