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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cppbeginner_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form9 f9 = new CodeLab.Form9();
            f9.Show();
        }

        private void cppintermediate_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form10 f10 = new CodeLab.Form10();
            f10.Show();
        }

        private void cppadvance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form11 f11 = new CodeLab.Form11();
            f11.Show();
        }

        private void cppback_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.homeForm f1 = new CodeLab.homeForm();
            f1.Show();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.homeForm f1 = new CodeLab.homeForm();
            f1.Show();
        }

        private void cpplearnmore_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form12 f12 = new CodeLab.Form12();
            f12.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
