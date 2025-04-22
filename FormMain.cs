using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinform
{
    public partial class FormMain : Form
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.Cancel:
                    return;
                    break;
                case DialogResult.OK:
                    lblFileName.Text = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        textBox1.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                    break;
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFileName.Text = "제목없음";
            textBox1.Text = "글자를 입력하세요~";
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == "제목없음")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
                DialogResult result = saveFileDialog.ShowDialog();

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                        break;
                    case DialogResult.OK:
                        lblFileName.Text = saveFileDialog.FileName;
                        break;
                }
            }

            using (StreamWriter sw = new StreamWriter(lblFileName.Text))
            {
                sw.Write(textBox1.Text);
                sw.Close();
            }

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
            saveFileDialog.FileName = lblFileName.Text;
            DialogResult result = saveFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.Cancel:
                    return;
                    break;
                case DialogResult.OK:
                    lblFileName.Text = saveFileDialog.FileName;
                    break;
            }

            using (StreamWriter sw = new StreamWriter(lblFileName.Text))
            {
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }
    }
}
