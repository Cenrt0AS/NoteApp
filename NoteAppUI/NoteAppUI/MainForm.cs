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

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Вызываем форм1
            //TestForm frm1 = new TestForm();
            Form1 frm1 = new Form1();
            frm1.Show();
           this.Hide();

        }

    }
}
