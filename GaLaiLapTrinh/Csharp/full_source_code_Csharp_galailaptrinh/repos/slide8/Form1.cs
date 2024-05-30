using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("item 9");
            lstDanhSach.Items.Add("item 10");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = lstDanhSach.Items.Count;
            MessageBox.Show("Số pt lst box là: " + a);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDanhSach.Items[2].ToString());
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.RemoveAt(2);
        }

        private void btnSelectedIndices_Click(object sender, EventArgs e)
        {
            foreach(int i in lstDanhSach.SelectedIndices)
            {
                Console.WriteLine(i);
            }
            //trả về giá trị phần tử đầu tiên trong list được chọn 
            Console.WriteLine(lstDanhSach.SelectedIndices[0]);
            //đếm 
            Console.WriteLine(lstDanhSach.SelectedIndices.Count);
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items[0] = "phần tử mới";
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index item đc đc chọn là: " + lstDanhSach.SelectedIndex);
        }
    }
}
