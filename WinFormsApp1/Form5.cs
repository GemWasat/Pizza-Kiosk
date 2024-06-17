using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "1";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "9";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "6";
        }

        private void btn_010_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "010";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString() + "0";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포인트 사용이 완료되었습니다.");
            Application.Exit();
        }
    }
}
