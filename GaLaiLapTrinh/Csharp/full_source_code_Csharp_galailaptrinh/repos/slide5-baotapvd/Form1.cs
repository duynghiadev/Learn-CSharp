using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide5_baotapvd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show(
                "Bạn có chắc muốn thoát? ", 
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            chkInNghieng.Checked = true;   
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
                lblOutput.ForeColor = radRed.ForeColor;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
                lblOutput.ForeColor=radGreen.ForeColor;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
                lblOutput.ForeColor = radBlue.ForeColor;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
                lblOutput.ForeColor = radBlack.ForeColor;
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lblOutput.Font.Name);
            Console.WriteLine(lblOutput.Font.Size);
            lblOutput.Font = new Font(
                txtNhapTen.Font.Name, 
                16, 
                lblOutput.Font.Style ^FontStyle.Bold);

            Console.WriteLine(lblOutput.Font.Name);
            Console.WriteLine(lblOutput.Font.Size);
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name, 
                lblOutput.Font.Size,
                lblOutput.Font.Style^FontStyle.Italic);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
            lblOutput.Font.Name,
            lblOutput.Font.Size,
            lblOutput.Font.Style ^ FontStyle.Underline);
        }
    }
}
