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
                TextTBox.Text = note.NoteText;
            }
        }

        public Note note;
        //TODO: Реализовать геттер и сеттер и через них передавать данные в компоненты.
        public string NoteTitle_Edit
        {
            get { return titleTBox.Text; }
            set { titleTBox.Text = value; }
        }

        public string NoteText_Edit
        {
            get { return TextTBox.Text;  }
            set { TextTBox.Text = value; }
        }

        public int NoteCategory_Edit
        {
            get { return ComboBoxCategory1.SelectedIndex; }
            set { ComboBoxCategory1.SelectedIndex = value; }
        }

        public DateTime CreatedDateTime_Edit
        {
            get { return createdDateTimePicker.Value; }
            set { createdDateTimePicker.Value = value; }
        }

        public DateTime ModifiedDateTime_Edit
        {
            get { return modifiedDateTimePicker.Value; }
            set { modifiedDateTimePicker.Value = value; }
        }

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

    }
}
