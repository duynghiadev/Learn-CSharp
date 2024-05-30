using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Add("pt new");
            chklbDanhSach.Items.Add(100);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Insert(1, 999);
        }

        private void btnAddrange_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.AddRange(new string[] { "pt9", "pt 10" });
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("spt cua chklb: " + chklbDanhSach.Items.Count);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Remove("san pham 2");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.RemoveAt(3);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Clear();
        }

        private void btnCheckedIndices_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection =
                chklbDanhSach.CheckedIndices;
            string strCheck = "";
            foreach (int i in indexCollection)
            {
                strCheck += i + " ";
            }
            MessageBox.Show("index pt dang dc chon la: " + strCheck);
        }

        private void btnCheckedItems_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items =
                chklbDanhSach.CheckedItems;
            string strItems = "";
            foreach (string s in items)
            {
                strItems += s + "   ";
            }
            MessageBox.Show(strItems);
        }

        private void btnGetItemChecked_Click(object sender, EventArgs e)
        {
            string strCheck = "";
            for (int i = 0;i<chklbDanhSach.Items.Count;i++)
            {
                if(chklbDanhSach.GetItemChecked(i) )
                {
                    strCheck += chklbDanhSach.Items[i] + "  ";
                }
            }
            MessageBox.Show(strCheck);
        }
    }
}
