using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace bai3_selenium_upanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpanh_Click(object sender, EventArgs e)
        {   
            //tat bang den si si 
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            // khai bao 
            IWebDriver driver = new ChromeDriver(chrome);

            //thông báo lên lbl
            lblDangXuLy.Text = "Em dang xu ly cho cu roi ah";

            driver.Url = "https://upanh.kmacfs.com/";

            //dieu huong 
            driver.Navigate();

            //bo dong dau 
            IWebElement dongdau = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[2]/div/span[2]/i"));
            Thread.Sleep(1000); // ngu 1s
            dongdau.Click();

            //Tìm element Start Uploading 
            IWebElement upload = driver.FindElement(By.Id("fileupload"));
            Thread.Sleep(1000); // ngu 1s
            upload.SendKeys(txtInput.Text);

            // tai len 
            Thread.Sleep(1000); // ngu 1s
            IWebElement tailen = driver.FindElement(By.Id("upload"));
            tailen.Click();
            Console.WriteLine("da up xong");

            //get link 
            Thread.Sleep(3000); // ngu 3s
            IWebElement textlink = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[4]/div/textarea"));
            string text = textlink.GetAttribute("value");
            Console.WriteLine(text);
            txtOut.Text = text;

            //dong trinh duyet 
            driver.Quit();

            //thong bao 
            lblDangXuLy.Text = "Xong roi cu oi, moi cu lay link ";
        }
    }
}
