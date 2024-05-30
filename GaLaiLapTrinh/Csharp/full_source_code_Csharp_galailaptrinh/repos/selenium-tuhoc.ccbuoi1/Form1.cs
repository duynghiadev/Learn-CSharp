using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace selenium_tuhoc.ccbuoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopenBrowser_Click(object sender, EventArgs e)
        {   
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            // dieu huong trinh duyet 
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("http://google.com.vn");

            //close 
            //driver.Close();
            //input j do vao o tim kiem 
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(txtUrl.Text);


        }

        private void openBrowser2_Click(object sender, EventArgs e)
        {
            //cach 2
            IWebDriver driver = new ChromeDriver();
            driver.Url = txtUrl.Text;
            driver.Navigate();
        }
    }
}
