using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Add("obama");
            cboDanhSach.Items.Add("ukraina");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Insert(1, 123);
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index pt dang chon la: " + cboDanhSach.SelectedIndex);
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item dang chon la: " + cboDanhSach.SelectedItem);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("so pt cbo la: " + cboDanhSach.Items.Count);
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.AddRange(new string[] { "pt1", "pt2", "pt3" });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Remove("item 1");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.RemoveAt(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Clear();
        }
    }
}
