using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Sqa.Util.Driver;

namespace Sqa.Util.UnitTest
{ 
    
    public class ChromeBrowserTest : ChromeBrowserDriver
    {
        
        public void Login(string username = "admin", string password = "***")
        {
            Go("https://www.reddit.com/");
            Find(By.Id("Email")).SendKeys(username);
            Find(By.Id("Password")).SendKeys(password);
            Find(By.Id("loginButton")).Submit();
        }

        [AutoTest]
        public void TestTry()
        {
            //Go("https://www.reddit.com/");
            //System.Threading.Thread.Sleep(3000);
            //Find(By.XPath("//*[@id='header']/div[3]/div/div[2]/form/input")).SendKeys("car");
            //Find(By.XPath("//*[@id='header']/div[3]/div/div[2]/form/input")).SendKeys(Keys.Enter);
            //System.Threading.Thread.Sleep(4000);



            //WebDriver.Navigate().Back();
            //System.Threading.Thread.Sleep(3000);
            //WebDriver.Navigate().Refresh();
            //System.Threading.Thread.Sleep(3000);

            ////click sign up
            //Find(By.XPath("//*[@id='header']/div[4]/a[2]")).Click();
            //System.Threading.Thread.Sleep(3000);
            //Find(By.ClassName("AnimatedForm__textInput")).SendKeys("asdf@gmail.com");
            //System.Threading.Thread.Sleep(3000);

            Go("https://www.yemeksepeti.com/ankara");
            System.Threading.Thread.Sleep(3000);
            Find(By.ClassName("select2-selection__arrow")).Click();
            System.Threading.Thread.Sleep(3000);
            Find(By.ClassName("select2-search__field")).SendKeys("Beytepe");
            System.Threading.Thread.Sleep(3000);
            Find(By.ClassName("select2-search__field")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(3000);
            Find(By.XPath("/html/body/header/div[2]/div/div/div[4]/button")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(3000);


            //Find(By.XPath("//*[@id='UserName']")).SendKeys("simay");
            //System.Threading.Thread.Sleep(3000);
            //Find(By.Id("ys-fastlogin-button")).Click();
            //System.Threading.Thread.Sleep(8000);
            //Find(By.Id("ys - areaSelector")).Click();
            //System.Threading.Thread.Sleep(3000);
            //Find(By.CssSelector("search")).SendKeys("Beytepe");
            //System.Threading.Thread.Sleep(3000);
            //Find(By.Id("ys-areaSelector")).SendKeys(Keys.Enter);
            //System.Threading.Thread.Sleep(3000);
            //Find(By.Id("ys-areaSelector")).SendKeys("Beytepe");
            // Find(By.Id("ys-areaSelector")).SendKeys(Keys.Enter);

            //Find(By.XPath("/html/body/header/div[2]/div/div/div[4]/button")).Click();
            //System.Threading.Thread.Sleep(8000);







            //var option = WebDriver.FindElement(By.Id("ys-areaSelector"));
            //option.SendKeys("Beytepe");
            //var selected = new SelectElement(option);
            //Go("https://www.yemeksepeti.com/ankara/beytepe");
            //System.Threading.Thread.Sleep(5000);

            ////selected.SelectByText("Beytepe");
            //System.Threading.Thread.Sleep(8000);
            ////Find(By.ClassName("select2-selection__arrow")).SendKeys("Beytepe");
            //Find(By.XPath("/html/body/header/div[2]/div/div/div[2]/span/span[1]/span")).SendKeys(Keys.Enter);



            Assert.True(true);
        }
        

        public override void DriverTearDown()
        {
        }
    }
}
