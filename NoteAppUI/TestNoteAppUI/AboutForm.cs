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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void GitHubURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GitHubURL.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/YalovskiyV/");
        }

        private void EmailURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailURL.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:something@mail.com");
        }
    }
}
