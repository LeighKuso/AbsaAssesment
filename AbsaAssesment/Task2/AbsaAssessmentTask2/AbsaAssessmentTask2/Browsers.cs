using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AbsaAssessmentTask2
{
    //A class to make the tests cross-platfrom compatable
    class Browsers
    {
        private static IWebDriver webDriver;

        public static void Init(string browser, string baseURL)
        {
            string _browser = browser;
            string _baseURL = baseURL;

            switch (_browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            Goto(_baseURL);
        }

        public static void Goto(string baseURL)
        {
            webDriver.Url = baseURL;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
