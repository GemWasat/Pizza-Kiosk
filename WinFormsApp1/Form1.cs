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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        //총 금액 업데이트 메소드
        private void UpdateTotal()
        {
            total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += int.Parse(item.SubItems[1].Text);
            }

            textBox1.Text = total.ToString();
        }

        int total = 0;

        //폼2로부터 전달받은 데이터를 리스트뷰에 출력
        public void ReceiveData(string data1, string data2)
        {
            listView1.Items.Add(new ListViewItem(new string[] { data1, data2 }));
            UpdateTotal();
        }

        // Form2를 열고 데이터를 전달하는 메서드
        private void OpenForm2(string data1, string data2)
        {

            Form2 form2 = new Form2(data1, data2);
            form2.ShowDialog();
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data1 = label1.Text;
            string data2 = label12.Text;
            OpenForm2(data1, data2);
            
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string data1 = label2.Text;
            string data2 = label13.Text;
            OpenForm2(data1, data2);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            string data1 = label3.Text;
            string data2 = label14.Text;
            OpenForm2(data1, data2);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string data1 = lb_pepe.Text;
            string data2 = lb_pepeprice.Text;
            OpenForm2(data1, data2);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string data1 = label5.Text;
            string data2 = label16.Text;
            OpenForm2(data1, data2);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            string data1 = label6.Text;
            string data2 = label17.Text;
            OpenForm2(data1, data2);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            string data1 = label7.Text;
            string data2 = label18.Text;
            OpenForm2(data1, data2);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string data1 = label8.Text;
            string data2 = label19.Text;
            OpenForm2(data1, data2);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            string data1 = label9.Text;
            string data2 = label20.Text;
            OpenForm2(data1, data2);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            string data1 = label10.Text;
            string data2 = label21.Text;
            OpenForm2(data1, data2);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            string data1 = label11.Text;
            string data2 = label22.Text;
            OpenForm2(data1, data2);
        }

        //취소 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView1.FocusedItem.Index;
                int removedValue = int.Parse(listView1.Items[index].SubItems[1].Text);

                listView1.Items.RemoveAt(index);//인덱스에 있는 항목을 모두 삭제

                // 텍스트박스에 있는 값도 삭제된 값만큼 빼줌
                total -= removedValue;

                // 텍스트박스에 결과를 표시
                textBox1.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { lb_meet.Text, lb_meetprice.Text }));
            UpdateTotal();

        }

        private void btn_crim_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { lb_crim.Text, lb_crimpasta.Text }));
            UpdateTotal();
        }

        private void btn_wing_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { lb_wing.Text, lb_wingprice.Text }));
            UpdateTotal();
        }

        private void btn_stic_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { lb_stic.Text, lb_sticprice.Text }));
            UpdateTotal();
        }

        private void btn_coke500_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { label31.Text, label32.Text }));
            UpdateTotal();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { label33.Text, label34.Text }));
            UpdateTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { label35.Text, label36.Text }));
            UpdateTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { label37.Text, label38.Text }));
            UpdateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            UpdateTotal();
        }

        //결제 화면으로 가기 
        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                
                total += int.Parse(item.SubItems[1].Text);
            }

            MessageBox.Show($"총 금액은 {total}원 입니다.");

            Form4 form4 = new Form4(listView1.Items.Cast<ListViewItem>().ToList());
            form4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
