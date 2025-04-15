using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinform
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "집에 가자~";
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout1 = new FormAbout();
            FormAbout formAbout2 = new FormAbout();

            // 모달창
            formAbout1.Text = "모달창";
            formAbout1.ShowDialog();

            // 모달리스창
            formAbout2.Text = "모달리스창";
            formAbout2.Show();
        }
    }
}
