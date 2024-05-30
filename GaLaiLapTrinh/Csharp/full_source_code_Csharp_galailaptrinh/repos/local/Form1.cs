using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace local
{
    
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static int HamNgauNhien()
        {
            Random rd = new Random();
            int soNgauNhien = rd.Next(0,101);
            return soNgauNhien;
        }
        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            int so = HamNgauNhien();
            lblKQ.Text=so.ToString();
        }
    }
}
