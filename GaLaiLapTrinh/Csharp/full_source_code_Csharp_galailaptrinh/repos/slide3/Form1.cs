using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cảm ơn đã tin em, nhưng trong này không có gì đâu", 
                "Thông báo ", 
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //DialogResult cc = MessageBox.Show(
            //    "Bạn có chắc chắn muốn thoát?",
            //    " Confirm",
            //    MessageBoxButtons.YesNo, Ctrl + K + C
            //    MessageBoxIcon.Warning);
            //if (cc == DialogResult.Yes)
            //    Close();
            //else if (cc == DialogResult.No)
            //    MessageBox.Show("Ok thím, mời thím tiếp tục dùng phần mềm");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "cảm ơn bạn đã dùng phần mềm");

        }
    }
}
