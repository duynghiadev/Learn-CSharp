using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide10_bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {   
            CheckedListBox.CheckedItemCollection items = chklbTrai.CheckedItems;
            foreach (var item in items)
            {
                //Console.WriteLine(item);
                chklbPhai.Items.Add(item);
            } 
            // Duyệt để xóa pt bên trái
            foreach(string s in chklbPhai.Items)
            {
                chklbTrai.Items.Remove(s);
            }    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            chklbPhai.Items.AddRange(chklbTrai.Items);
            // xóa all bên trái
            chklbTrai.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklbPhai.CheckedItems;
            foreach (var item in items)
            {
                //Console.WriteLine(item);
                chklbTrai.Items.Add(item);
            }
            // Duyệt để xóa pt bên trái
            foreach (string s in chklbTrai.Items)
            {
                chklbPhai.Items.Remove(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chklbTrai.Items.AddRange(chklbPhai.Items);
            // xóa all bên phải
            chklbPhai.Items.Clear();
        }
    }
}
