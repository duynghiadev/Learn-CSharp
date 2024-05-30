using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace slide6_baitap
{   
    public partial class Form1 : Form
    {
        private SoundPlayer choiNhac;
        public Form1()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer("nhactap2.wav");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Close();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            if (picHaTa.Visible == false)
                btnClick.Text = txtName.Text + "! Click để Hạ tạ đi cụ";
            else
                btnClick.Text = txtName.Text + "! Click để Nâng tạ đi cụ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHaTa.Visible = false;
            picNangTa.Visible = true;
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {   
            if (picHaTa.Visible == false)
            {
                picHaTa.Visible = true;
                picNangTa.Visible = false;
                btnClick.Text = btnClick.Text.Replace("Hạ", "Nâng");
                lblCount.Text = count.ToString();
                count++;  
                if (count == 11)
                {
                    DialogResult result = MessageBox.Show(
                        "Cụ nhấp khỏe quá, được 10 cái, hoàn thành ngày hôm nay, cụ có nhấp tiếp không?",
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );
                    if (result == DialogResult.No)
                        Close();

                }    
            }    
            else
            {
                picHaTa.Visible=false;
                picNangTa.Visible=true;
                btnClick.Text = btnClick.Text.Replace("Nâng", "Hạ");
            }    
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                choiNhac.Play();
            else
                choiNhac.Stop();
        }
    }
}
