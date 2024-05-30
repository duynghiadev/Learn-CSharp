using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace selenium_tuhoc.cc_buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://google.com.vn";
            driver.Navigate();

            //get 
            string link_hientai = driver.Url;
            Console.WriteLine(link_hientai);

            //get tieu de 
            string tieude = driver.Title;
            Console.WriteLine(tieude);
            //cach 2 
            txtoutput.Text = driver.Title;

            //page source
            string pages = driver.PageSource;
            Console.WriteLine(pages);

            //close
            //driver.Quit();  

            driver.Navigate().GoToUrl("http://shopee.vn");
            
            //back
            driver.Navigate().Back();

            Thread.Sleep(2000); // ngu 2000 ms 
            //fw
            driver.Navigate().Forward();

            //f5
            Thread.Sleep(1000);
            driver.Navigate().Refresh();
            Thread.Sleep(1000);
            driver.Navigate().Refresh();
            Thread.Sleep(1000);
            driver.Navigate().Refresh();


        }

        private void btnbai3_Click(object sender, EventArgs e)
        {
            //tao 1 doi tuong moi 
            IWebDriver driver = new ChromeDriver();
            //khai bao url 
            driver.Url = "https://demosite.executeautomation.com/index.html?UserName=tuhoc.cc&Password=123456&Login=Login";
            driver.Navigate();

            //IWebElement element = driver.FindElement(By.Name("UserName"));
            //element.SendKeys(txtUser.Text);

            //IWebElement pass_cuatui = driver.FindElement(By.Name("Password"));
            //pass_cuatui.SendKeys(txtMK.Text);

            //element.Clear();
            //Thread.Sleep(2000);
            IWebElement gen = driver.FindElement(By.Name("generate"));
            //dangnhap.Click();

            bool ktra = gen.Displayed;
            Console.WriteLine(ktra);

            IWebElement check = driver.FindElement(By.Name("Female"));
            bool ktra2 = check.Selected;
            Console.WriteLine("tinh trang cua o nay la , tru/false: " + ktra2);


            IWebElement Save_button = driver.FindElement(By.Name("Save"));
            var kichthuoc = Save_button.Size;
            Console.WriteLine("cao: " +kichthuoc.Height+"rong: " +kichthuoc.Width);

            Point vitri = Save_button.Location;
            Console.WriteLine("toa go x: " +vitri.X +"toa do y: " +vitri.Y);

            IWebElement elm5 = driver.FindElement(By.LinkText("HtmlPopup"));
            Console.WriteLine(elm5.GetAttribute("href"));

            driver.Quit();
        }

        private void txtoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbai4_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demosite.executeautomation.com/index.html?UserName=tuhoc.cc&Password=123456&Login=Login";

            IWebElement element = driver.FindElement(By.Id("Initial"));
            element.SendKeys("haha");

            IWebElement element2 = driver.FindElement(By.Id("FirstName"));
            element2.SendKeys("jacky");


            IWebElement element3 = driver.FindElement(By.Id("MiddleName"));
            element3.SendKeys("chan");

        }

        private void btnshopee_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://shopee.vn";
            driver.Navigate();
            IWebElement element = driver.FindElement(By.ClassName("shopee-searchbar-input__input"));
            element.SendKeys("giay nam");

            //by.linktext
            IWebElement element2 = driver.FindElement(By.LinkText("Kênh Người"));
            Console.WriteLine(element2.GetAttribute("href"));

            IWebElement element3 = driver.FindElement(By.PartialLinkText("Kênh Người"));
            Console.WriteLine(element3.GetAttribute("href"));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demosite.executeautomation.com/";
            driver.Navigate();

            IWebElement element = driver.FindElement(By.Name("UserName"));
            element.SendKeys("tuhoc.cc");


            IWebElement element2 = driver.FindElement(By.Name("Password"));
            element2.SendKeys("123456");

            IWebElement element3 = driver.FindElement(By.XPath("//*[@id=\"userName\"]/p[3]/input"));
            element3.Click();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://vi.wikipedia.org/wiki/Trang_Ch%C3%ADnh/";
            driver.Navigate();

            IWebElement element = driver.FindElement(By.CssSelector("#p-createaccount > a > span"));
            element.Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://en.wikipedia.org/wiki/I_Want_to_Love_You";
            driver.Navigate();

            IWebElement element = driver.FindElement(By.TagName("h2"));
            Console.WriteLine(element.Text);

            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://en.wikipedia.org/wiki/I_Want_to_Love_You";
            driver.Navigate();

            ReadOnlyCollection<IWebElement> elments  = driver.FindElements(By.TagName("h2"));
            foreach(var el in elments)
            {
                Console.WriteLine(el.Text);
            }


            driver.Quit();
        }
    }
}
