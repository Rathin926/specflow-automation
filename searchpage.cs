using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyseleniumPOM2
{
    public class searchpage : POMbasepage

    {
        public searchpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = "//input[@name='field-keywords']")]
        public IWebElement searchbox;
        [FindsBy(How = How.XPath, Using = "//input[@value='Go']")]
        public IWebElement searchbtt;
        public void searchitems()
        {
            searchbox.SendKeys("electronics");
            searchbtt.Click();
        }

    }
}
