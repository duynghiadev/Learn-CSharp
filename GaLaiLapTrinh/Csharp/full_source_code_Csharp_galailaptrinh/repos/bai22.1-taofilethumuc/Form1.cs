using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bai22._1_taofilethumuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //check xem nguoi dung da chon thu muc chua
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowser.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                MessageBox.Show("Ban chua chon thu muc thanh cong");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(txtBrowser.Text != "")
            {
                //check thu muc co ton tai hay o , neu o bao loi
                string path = txtBrowser.Text;
                if(Directory.Exists(path))
                {
                    //duyệt for để tạo hàng loạt 
                    for (int i = 1; i<=10;i++)
                    {
                        //them file hang loat
                        string pathCreat = path + @"\teptin" + i + ".txt";
                        //Console.WriteLine(pathCreat);
                        FileInfo f = new FileInfo(pathCreat);
                        f.Create();
                    }
                    MessageBox.Show("Da tao xong");
                }
                else
                {
                    MessageBox.Show("duong dan khong  ton tai, kiem tra lai");
                }
            }
            else
            {
                MessageBox.Show("Ban chua chon duong dan");
            }

        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            if (txtBrowser.Text != "")
            {
                //check thu muc co ton tai hay o , neu o bao loi
                string path = txtBrowser.Text;
                if (Directory.Exists(path))
                {
                    //duyệt for để tạo hàng loạt 
                    for (int i = 1; i <= 10; i++)
                    {
                        //them thu muc  hang loat
                        string pathCreat = path + @"\thumuc" + i + ".txt";
                        //Console.WriteLine(pathCreat);
                        DirectoryInfo f = new DirectoryInfo(pathCreat);
                        f.Create();
                    }
                    MessageBox.Show("Da tao xong");
                }
                else
                {
                    MessageBox.Show("duong dan khong  ton tai, kiem tra lai");
                }
            }
            else
            {
                MessageBox.Show("Ban chua chon duong dan");
            }
        }
    }
}
