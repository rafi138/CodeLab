using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CodeLab
{
    public partial class homeForm : Form
    {

        public homeForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            head_menu.Visible = true;
            homepictureBox.Visible = true;
            t.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new StartScreen());
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void home_csrp_click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new CodeLab.Form4();
            f4.Show();
        }



        private void home_c_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new CodeLab.Form2();
            f2.Show();
        }

        private void home_cpp_click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new CodeLab.Form3();
            f3.Show();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
