using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Selenium
{
    public class DataDriverTesting
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://eaapp.somee.com");
            _driver.Manage().Window.Maximize();
            ReadJsonFile();
        }

        [Test]
        [Category("DataDriven")]
        [TestCaseSource(nameof(Login))]

        public void TestWithPOM(LoginModel loginModel)
        {
            //POM initialization
            //Arrange
            LoginPage loginPage = new LoginPage(_driver);
            //Act
            loginPage.ClickLogin();
            loginPage.Login(loginModel.UserName,loginModel.Password );
            //Assert
            var getLoggedIn = loginPage.IsLoggedIn();
            Assert.IsTrue(getLoggedIn);
        }
        public static IEnumerable<LoginModel> Login()
            {
            yield return new LoginModel()
            {
                UserName = "admin",
                Password = "password"
            };

            }
        private void ReadJsonFile()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login.json");
            var jsonString = File.ReadAllText(jsonFilePath); //read json file
            //desearlize the file into specific type
            var loginModel = JsonSerializer.Deserialize<LoginModel>(jsonString);    
            Console.WriteLine($"UserName : {loginModel.UserName} : {loginModel.Password}");         
        
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }



    }
}
