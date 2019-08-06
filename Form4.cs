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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void csrpbeginner_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form13 f13 = new CodeLab.Form13();
            f13.Show();
        }

        private void csrpintermediate_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form14 f14 = new CodeLab.Form14();
            f14.Show();
        }

        private void csrpadvance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form15 f15 = new CodeLab.Form15();
            f15.Show();
        }

        private void csrpback_button_Click(object sender, EventArgs e)
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

        private void csrplearnmore_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeLab.Form16 f16 = new CodeLab.Form16();
            f16.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
