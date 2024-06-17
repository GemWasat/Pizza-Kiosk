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
    public partial class Form4 : Form
    {
        private List<ListViewItem> listViewItems;
        public Form4(List<ListViewItem> listViewItems)
        {
            InitializeComponent();
            this.listViewItems = listViewItems;
            foreach (var item in listViewItems)
            {
                listBox1.Items.Add(item.Text + " - " + item.SubItems[1].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rd_card.Checked || rd_point.Checked) == false)
            {
                MessageBox.Show("결제방법을 선택해 주세요");
            }
            else if ((rd_print.Checked || rd_nonprint.Checked) == false)
            {
                MessageBox.Show("영수증 출력 여부를 선택해 주세요");
            }
            else
            {
                if (rd_point.Checked)
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
                else if (rd_card.Checked)
                {
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
