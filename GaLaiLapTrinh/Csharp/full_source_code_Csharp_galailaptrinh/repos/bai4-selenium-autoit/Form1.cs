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
using AutoItX3Lib;


namespace bai4_selenium_autoit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //tat bang den 
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url = "https://online2pdf.com/";
            //dieu huong 
            driver.Navigate();

            //tim selcct file 
            IWebElement selctFile = driver.FindElement(By.XPath("//*[@id=\"div_file_box0_0\"]/div[1]/div[1]/table/tbody/tr/td/div[1]/button"));
            selctFile.Click();

            // khởi tạo đối tượng autoIT
            AutoItX3 auto = new AutoItX3();
            // lấy ra cửa sổ active có tiêu đề như dưới
            auto.WinActivate("Open");
            Thread.Sleep(1000);

            string path = "\""+ @"C:\Users\GaLaiLapTrinh\Desktop\mau\tuhoc1.pptx" + "\" " + "\"" + @"C:\Users\GaLaiLapTrinh\Desktop\mau\tuhoc2.pptx" + "\" " ;
            auto.Send(path);
            Thread.Sleep(1000);

            // nhan phim enter 
            auto.Send("{ENTER}");
            Thread.Sleep(1000);


            // tim nut convert 
            IWebElement convert = driver.FindElement(By.ClassName("convert_button"));
            convert.Click();

        }
    }
}
