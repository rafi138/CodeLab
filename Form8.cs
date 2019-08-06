using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.homeForm f1 = new CodeLab.homeForm();
            f1.Show();
        }

        private void clmback_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form2 f2 = new CodeLab.Form2();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
