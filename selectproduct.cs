using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace easyseleniumPOM2
{
    
    [TestFixture]
    public class selectproduct:POMbasetest
    {
        [Test]
        public void  Selectproduct()
        {
            inIt("chrome");
            POMlaunchingpage launchingpage = new POMlaunchingpage(driver);
            PageFactory.InitElements(driver,launchingpage);
            launchingpage.openapp();
            searchpage search = new searchpage(driver);
            PageFactory.InitElements(driver, search);
            search.searchitems();
            IWebElement element = driver.FindElement(By.XPath("//span[contains(text(),'899')]"));
            IWebElement price = driver.FindElement(By.XPath("//span[contains(text(),'899')]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(price);
            string Bprice = price.Text;
            actions.Perform();
            takeScreenShot();           
            Console.WriteLine(price.Text);
            driver.FindElement(By.XPath("//h2[contains(text(),'Mi 10000mAH Li-Polymer Power Bank 2i (Black)')]")).Click();
            IList<string> win = driver.WindowHandles;         
            Console.WriteLine(win.Count);
            driver.SwitchTo().Window(win[1]);
            driver.FindElement(By.XPath("//input[@title='Add to Shopping Cart']")).Click();
            driver.FindElement(By.XPath("//a[@id='hlb-ptc-btn-native']")).Click();
            Signin Signin = new Signin(driver);
            PageFactory.InitElements(driver, Signin);
            Signin.loginclick();
            Thread.Sleep(3000);
            IWebElement finalprice=driver.FindElement(By.XPath("//td[@class='a-size-medium a-color-price aok-align-bottom aok-nowrap grand-total-price a-text-right']//span[contains(text(),'899.00')]"));
           string Aprice = finalprice.Text;             
            if (Bprice.Equals(finalprice.Text))
            {
                Console.WriteLine("Both prices are same");
           }
            else
            {
                Console.WriteLine("Both prices are not same");

            }

        } 

            





        
    }
}
