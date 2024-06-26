﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai15_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // cong viec chinh m at thoi  gian 
            int sum = 0;
            for (int i = 0; i <=100; i++)
            {
                Thread.Sleep(100);
                sum +=i;
                // goi su kien progresschanged
                backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }


            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            //update % len value bar 
            progressBar1.Value = e.ProgressPercentage;
            //update % len label
            label1.Text = e.ProgressPercentage.ToString() +"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label2.Text = "Tien trinh bi huy roi ong giao ah";
            }
            else if (e.Error != null)
            {
                label2.Text = e.Error.Message;
            }
            else
            {
                label2.Text = "Ket qua cua ong giao la" +e.Result.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            //check backg co dang bi ban hay 
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                label2.Text = " Cho ti ong giao, dang xu ly chua xong";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // neu worker dang chay thi cancel de dung 
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            else
            {
                label2.Text = "em dang o co j de lam, o can dung";
            }
        }
    }
}
