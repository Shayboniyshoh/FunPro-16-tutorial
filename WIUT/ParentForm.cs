using System;
using System.Windows.Forms;

namespace WIUT
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var show = new AboutForm();
            //show.MdiParent = this;
            show.ShowDialog();
        }
    }
}
