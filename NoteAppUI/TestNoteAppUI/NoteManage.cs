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

        public Note Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
                titleTBox.Text = note.Title;
                TextTBox.Text = note.Text;
                ComboBoxCategory1.SelectedIndex = Convert.ToInt32(note.Category);
                createdDateTimePicker.Value = note.DateofCreation;
                modifiedDateTimePicker.Value = note.LastmodDate;
            }
        }

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
            note = new Note(titleTBox.Text, TextTBox.Text, (NoteCategory)Category, DateTime.Now, DateTime.Now);                  
            DialogResult = DialogResult.OK;
        }

        private void titleTBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTBox.TextLength>50)
            {
                DialogResult result = MessageBox.Show(
                "Длина имени не может быть больше 50 символов",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                titleTBox.Text = "Non correct";
            }
        }
    }
}
