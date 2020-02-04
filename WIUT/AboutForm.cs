using System;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class AboutForm : Form
    {
        public AboutForm()
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

        private void btnEnter_Click(object sender, EventArgs e)
        {

            try
            {
                var c = new Course();
                c.Name = tbxName.Text;
                MessageBox.Show("Successfully recieved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
