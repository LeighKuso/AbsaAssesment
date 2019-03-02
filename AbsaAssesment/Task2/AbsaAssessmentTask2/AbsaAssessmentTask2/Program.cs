using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace AbsaAssessmentTask2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            WebDriver.Driver = new ChromeDriver();
            WebDriver.Driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/webtables/");
            Console.WriteLine("URL Opened");
            
        }

        [Test]
        public void VerifyPage()
        {
            Assert.IsTrue(WebDriver.Driver.PageSource.Contains("First Name"));
        }

        [Test]
        public void AddUser1()
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/table/thead/tr[2]/td/button")).Click();
            Console.WriteLine("Open AddUser Form");

            
            Methods.EnterFirstName("FName1");
            Methods.EnterLastName("LName1");
            Methods.EnterUserName("User1");
            Methods.EnterPassword("Pass1");
            Methods.EnterEmail("Admin@mail.com");
            Methods.EnterPhoneNumber("082555");
            Methods.SelectCompanyA();
            Methods.SelectRole(WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[6]/td[2]/select")), "Admin");
            Console.WriteLine("Enter details to the form");

            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/button[2]")).Click();
            Console.WriteLine("Click Save");

            Assert.Equals(WebDriver.Driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td[1]")), "FName1");
        }

        [Test]
        public void AddUser2()
        {
            WebDriver.Driver.FindElement(By.XPath("/html/body/table/thead/tr[2]/td/button")).Click();
            Console.WriteLine("Open AddUser Form");

            Methods.EnterFirstName("FName2");
            Methods.EnterLastName("LName2");
            Methods.EnterUserName("User2");
            Methods.EnterPassword("Pass2");
            Methods.EnterEmail("cusomter@mail.com");
            Methods.EnterPhoneNumber("083444");
            Methods.SelectCompanyB();
            Methods.SelectRole(WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[6]/td[2]/select")), "Customer");
            Console.WriteLine("Enter details to the form");

            WebDriver.Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/button[2]")).Click();
            Console.WriteLine("Click Save");
            
            Assert.Equals(WebDriver.Driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td[1]")), "FName2");
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Driver.Close();
            Console.WriteLine("Browser Closed");
        }

        
    }
}
