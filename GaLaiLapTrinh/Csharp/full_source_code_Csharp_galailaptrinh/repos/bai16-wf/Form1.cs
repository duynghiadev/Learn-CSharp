using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ban da tao file moi");
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ban da mo file");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            mnuFileOpen.PerformClick();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            mnuFileNew.PerformClick();
        }
    }
}
