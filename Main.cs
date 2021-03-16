using System;
using System.Windows.Forms;

namespace OrganizerB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutComands about = new AboutComands();
            about.ShowDialog();
        }
    }
}
