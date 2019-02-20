using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyseleniumPOM2
{
    public class Signin : POMbasepage
    {
        public Signin(IWebDriver driver)
        {
            this.driver = driver;
        }
        
            [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        public IWebElement email;
        [FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
       public  IWebElement conbutt;
        [FindsBy(How = How.XPath, Using = "//input[@id='ap_password']")]
        public IWebElement password;
        [FindsBy(How = How.XPath, Using = "//input[@id='signInSubmit']")]
        public IWebElement submit;
        public void loginclick()
        {
            email.SendKeys("918106043838");
            conbutt.Click();
            password.SendKeys("qazwsx123");
            submit.Click();

        }





    }
    
}
