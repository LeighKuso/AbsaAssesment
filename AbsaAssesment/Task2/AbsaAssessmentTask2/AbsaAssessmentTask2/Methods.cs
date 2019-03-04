using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AbsaAssessmentTask2
{
    class Methods
    {
        public static void EnterFirstName(string FirstName)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[1]/td[2]/input")).SendKeys(FirstName);
        }

        public static void EnterLastName(string LastName)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[2]/td[2]/input")).SendKeys(LastName);
        }

        public static void EnterUserName(string UserName)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[3]/td[2]/input")).SendKeys(UserName);
        }

        public static void EnterPassword(string Password)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[4]/td[2]/input")).SendKeys(Password);
        }

        public static void EnterEmail(string email)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[7]/td[2]/input")).SendKeys(email);
        }

        public static void EnterPhoneNumber(string phone)
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[8]/td[2]/input")).SendKeys(phone);
        }

        public static void SelectCompanyA()
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[5]/td[2]/label[1]/input")).Click();
        }

        public static void SelectCompanyB()
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[5]/td[2]/label[2]/input")).Click();
        }

        public static void SelectRole(IWebElement ele, string text)
        {
            SelectElement select = new SelectElement(ele);
            select.SelectByText(text);
        }
    }
}
