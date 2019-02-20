using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyseleniumPOM2
{
    public class POMlaunchingpage : POMbasepage
    {

        public POMlaunchingpage(IWebDriver driver)
        { 
        this.driver=driver;
            
            }
        public void openapp()
        {
            driver.Url = "https://www.amazon.in/";
        }
            

    }
}
