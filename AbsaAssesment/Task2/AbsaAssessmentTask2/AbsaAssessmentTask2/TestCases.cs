using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AbsaAssessmentTask2
{
    [TestFixture]
    public class AutomationCore
    {

        [SetUp]
        public void StartTest()
        {
            Browsers.Init("Chrome", "http://www.way2automation.com/angularjs-protractor/webtables/");
        }

        [TearDown]
        public void Endtest()
        {
            Browsers.Close();
        }

        [Test]
        public void VerifyPage()
        {

        }
    }
}