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
    public partial class Form2 : Form
    {
        

        private string data1; //메뉴 이름

        private string data2;// 피자 가격

        //폼1으로부터 전달받을 생성자
        public Form2(string data1,string data2)
        {
            InitializeComponent();
            this.data1 = data1;
            this.data2 = data2;
        }


        int total2 = 0;

        //확정 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(radioButton3.Checked || radioButton4.Checked || radioButton5.Checked )) 
            {
                MessageBox.Show("도우를 선택 해주세요");
            }
            else
            {
                int dat = int.Parse(data2);
                string total = (total2 + dat).ToString(); //피자 가격 + 토핑
                
                // 폼1으로 데이터 전달
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.ReceiveData(data1,total);

                
                // 폼2 닫기
                this.Close();
               
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }

        private void rd_L_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_L.Checked)
            {
                total2 += int.Parse(lb2_cheese.Text);

            }
            else
            {
                total2 -= int.Parse(lb2_cheese.Text);
            }
            tb_1.Text = total2.ToString();
        }
    }
}
