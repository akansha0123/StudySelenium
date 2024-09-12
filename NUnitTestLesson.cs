using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;

namespace Selenium
{
    [TestFixture("admin", "password")]// optional from nunit 3
  //  [TestFixture("admin", "password1")]// similar way to dd
    public class NUnitTestLesson
    {
        private IWebDriver _driver;
        private readonly string userName;
        private readonly string password;

        //  private readonly string _userName;

        public NUnitTestLesson(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://eaapp.somee.com");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        [Category("Smoke")]

        public void TestWithPOM()
        {
            //POM initialization
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.ClickLogin();
            loginPage.Login(userName, password);
        }

        [Test]
        [TestCase("chrome","128")]
        public void TestBrowserVersion(string browser, string version)
        {
            Console.WriteLine($"The browser is {browser} with version {version}");
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
