using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide7_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Bạn chưa nhập phone...");
                check = false;
            }    
                
                

            //Tuổi 
            int tuoi;
            if(int.TryParse(txtTuoi.Text, out tuoi)==false)
            {
                errorProvider1.SetError(txtTuoi, "Sai định dạng..");
                check = false;
            }  
            else
            {
                if(tuoi <17)
                {
                    errorProvider1.SetError(txtTuoi, "Tuổi phải lớn hơn 17");
                    check = false;
                }    
            }   
            
            //ktra ngày đky
            if (dtpDK.Value.DayOfWeek== DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDK, "Thứ 2 em o chiếu phim nhé");
                check = false;
            }

            if (check)
                MessageBox.Show("Bạn đã đăng ký thành công, tôi sẽ liên hệ với bạn");


        }
    }
}
