﻿using System;
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
        public NoteManage()
        {
            InitializeComponent();
            cbCategory1.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
