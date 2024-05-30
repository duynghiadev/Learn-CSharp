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

namespace bai20_savefiledialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //tieu de
            saveFileDialog1.Title = "Day la tieu de ";
            //filter 
            saveFileDialog1.Filter = "Text file|*.txt |Pdf file|*.pdf |All file|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,txtNoiDung.Text );
            }
            else
            {
                MessageBox.Show("ban chua luu noi dung");
            }
        }
    }
}
