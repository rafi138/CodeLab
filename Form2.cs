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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cbeginner_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form5 f5 = new CodeLab.Form5();
            f5.Show();
        }

        private void cintermediate_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form6 f6 = new CodeLab.Form6();
            f6.Show();
        }

        private void cadvance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form7 f7 = new CodeLab.Form7();
            f7.Show();
        }

        private void cback_button_Click(object sender, EventArgs e)
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

        private void clearnmore_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form8 f8 = new CodeLab.Form8();
            f8.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
