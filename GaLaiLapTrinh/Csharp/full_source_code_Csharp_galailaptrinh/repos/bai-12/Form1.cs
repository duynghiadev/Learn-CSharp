using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpenForm1_Click(object sender, EventArgs e)
        {
            frm1 form1 = new frm1();
            form1.MdiParent =this;
            form1.Show();

        }

        private void mnuOpenForm2_Click(object sender, EventArgs e)
        {
            frm2 form2 = new frm2();
            form2.MdiParent =this;
            form2.Show();
        }

        private void mnuOpenForm3_Click(object sender, EventArgs e)
        {
            frm3 form3 = new frm3();
            form3.MdiParent =this;
            form3.Show();
        }

        private void mnuOpenForm4_Click(object sender, EventArgs e)
        {
            frm4 form4 = new frm4();
            form4.MdiParent =this;
            form4.Show();
        }

        private void sx1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void sx2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void sx3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void sx4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
