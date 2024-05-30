using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiquayso
{
    public partial class Form1 : Form
    {
        int TienNguoiChoi = 100;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (TienNguoiChoi < 20)
                MessageBox.Show("Ban khong du 20 xu, nap them xu cho thang chu quan");
            else
            {
                //tru tien nguoi choi
                TienNguoiChoi = TienNguoiChoi - 20;
                txtTienNguoiChoi.Text = TienNguoiChoi+"";
                //start time
                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rd.Next(0, 8)+"";
            lbl2.Text = rd.Next(0, 9)+"";
            lbl3.Text = rd.Next(0, 10)+"";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (lbl1.Text == "7")
                TienNguoiChoi += 30;
            if(lbl2.Text == "7")
                TienNguoiChoi += 40;
            if(lbl3.Text == "7")
                TienNguoiChoi += 50;
            txtTienNguoiChoi.Text = TienNguoiChoi + "";


        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            TienNguoiChoi = 100;
            txtTienNguoiChoi.Text = TienNguoiChoi + "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
