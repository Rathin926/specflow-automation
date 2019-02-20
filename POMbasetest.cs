using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyseleniumPOM2
{
    public class POMbasetest : POMbasepage
    {
        public void inIt(string Btype)
        {
            if (Btype.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (Btype.Equals("Mozilla"))
            {

                driver = new FirefoxDriver();

            }
            else if (Btype.Equals("Edge"))
            {

                driver = new EdgeDriver();

            }
        }
        public void takeScreenShot()
        {
            OpenQA.Selenium.Screenshot screen = driver.TakeScreenshot();

            string filename = DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
            string filpath = @"N:\Reports\" + filename;
            screen.SaveAsFile(filpath, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);

        }
    }
}
