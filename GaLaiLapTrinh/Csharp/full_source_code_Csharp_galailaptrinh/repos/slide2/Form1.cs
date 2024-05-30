using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSoNguyenA_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text+ " + " + txtB.Text +" = " +  tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn RS? ", 
                "Confirm", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txtB.Text = "";
                txtA.Text = "";
            }    
        }
    }
}
