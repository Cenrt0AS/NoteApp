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
        public NoteManage(Project dictionary, int actionNumber)
        {
            InitializeComponent();
            cbCategory1.DataSource = Enum.GetValues(typeof(NoteCategory));

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: Добавление
            int Category = cbCategory1.SelectedIndex;
            if (Naction == 1)
           Note note = new Note(titleTBox.Text, textBox1.Text,(NoteCategory)Category, DateTime.Now, DateTime.Now);
            
            //TODO: Редактирование

            //TODO: добавить сюда сохранение.
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
