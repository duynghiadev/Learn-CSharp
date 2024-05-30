using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17_lv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                string ma = lv1.SubItems[0].Text;
                string ten = lv1.SubItems[1].Text;
                string gia = lv1.SubItems[2].Text;
                //MessageBox.Show(ma+"/"+ten+"/"+gia);
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtGia.Text = gia;
                
            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column !=-1)
            {
                ColumnHeader cot = lvSanPham.Columns[e.Column];
                MessageBox.Show("cot ban chon la : " + cot.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtMa.Text);
            // them cac o tiep theo 
            lv1.SubItems.Add(txtTen.Text);
            lv1.SubItems.Add(txtGia.Text);

            lvSanPham.Items.Add(lv1);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            while (lvSanPham.SelectedItems.Count > 0)
            {
                Console.WriteLine(lvSanPham.SelectedItems[0].Index);
                lvSanPham.Items.RemoveAt(lvSanPham.SelectedItems[0].Index);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lvSanPham.SelectedItems.Count > 0)
            {
                lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0) ;
            {
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                lv1.SubItems[0].Text =txtMa.Text;
                lv1.SubItems[1].Text =txtTen.Text;
                lv1.SubItems[2].Text =txtGia.Text;
            }
        }
    }
}
