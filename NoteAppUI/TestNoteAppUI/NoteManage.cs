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
        public NoteManage(Project dictionary)
        {
            InitializeComponent();
            ComboBoxCategory1.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            int Category = ComboBoxCategory1.SelectedIndex;
            note = new Note(titleTBox.Text, textBox1.Text, (NoteCategory)Category, DateTime.Now, DateTime.Now);                  
            DialogResult = DialogResult.OK;
        }

    }
}
