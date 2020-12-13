using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SENG8040_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://localhost/Home.html");

        }
    }
}













//driver.FindElement(By.ClassName("button1")).Click();
//driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/input[1]")).SendKeys("Alex");
//driver.FindElement(By.XPath("//tbody/tr[2]/td[2]/textarea[1]")).SendKeys("40 alred road");
//driver.FindElement(By.XPath("//tbody/tr[3]/td[2]/input[1]")).SendKeys("Brampton");
//driver.FindElement(By.XPath("//tbody/tr[4]/td[2]/input[1]")).SendKeys("1234");
//driver.FindElement(By.XPath("//tbody/tr[5]/td[2]/input[1]")).SendKeys("Alex@gmail.com");
//driver.FindElement(By.XPath("//tbody/tr[6]/td[2]/input[1]")).SendKeys("vw");
//driver.FindElement(By.XPath("//tbody/tr[7]/td[2]/input[1]")).SendKeys("jetta");
//driver.FindElement(By.XPath("//tbody/tr[8]/td[2]/input[1]")).SendKeys("2012");
//driver.FindElement(By.XPath("//tbody/tr[9]/td[2]/input[1]")).Click();







//driver.FindElement(By.XPath("//button[contains(text(), 'Search')]")).Click();



//// driver.FindElement(By.ClassName("button1")).Click();
////driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/input[1]")).SendKeys("Alex");
////driver.FindElement(By.XPath("//tbody/tr[2]/td[2]/textarea[1]")); //.SendKeys("40 alred road");
////driver.FindElement(By.XPath("//tbody/tr[3]/td[2]/input[1]")).SendKeys("Brampton");
////driver.FindElement(By.XPath("//tbody/tr[4]/td[2]/input[1]")).SendKeys("647-555-8888");
////driver.FindElement(By.XPath("//tbody/tr[5]/td[2]/input[1]")).SendKeys("Alex@gmail.com");
////driver.FindElement(By.XPath("//tbody/tr[6]/td[2]/input[1]")).SendKeys("vw");
////driver.FindElement(By.XPath("//tbody/tr[7]/td[2]/input[1]")).SendKeys("jetta");
////driver.FindElement(By.XPath("//tbody/tr[8]/td[2]/input[1]")).SendKeys("2012");
////driver.FindElement(By.XPath("//tbody/tr[9]/td[2]/input[1]")).Click();




























//            driver.FindElement(By.ClassName("button1")).Click();

//            driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/input[1]")).SendKeys("Alex");
//            driver.FindElement(By.XPath("//tbody/tr[2]/td[2]/textarea[1]"));//.SendKeys("40 alred road");
//            driver.FindElement(By.XPath("//tbody/tr[3]/td[2]/input[1]")).SendKeys("Brampton");
//            driver.FindElement(By.XPath("//tbody/tr[4]/td[2]/input[1]")).SendKeys("647-555-8888");
//            driver.FindElement(By.XPath("//tbody/tr[5]/td[2]/input[1]")).SendKeys("Alex@gmail.com");
//            driver.FindElement(By.XPath("//tbody/tr[6]/td[2]/input[1]")).SendKeys("vw");
//            driver.FindElement(By.XPath("//tbody/tr[7]/td[2]/input[1]")).SendKeys("jetta");
//            driver.FindElement(By.XPath("//tbody/tr[8]/td[2]/input[1]")).SendKeys("2012");
//            driver.FindElement(By.XPath("//tbody/tr[9]/td[2]/input[1]")).Click();
//            String currentURL = driver.Url;
//            String expectedURL = "http://localhost/Display.php";
//            if (currentURL == expectedURL)
//            {
//                Console.WriteLine("Pass");
//            }
//            else
//            {
//                Console.WriteLine("Fail");
//            }








//        }
//    }
//}
