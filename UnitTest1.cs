using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using excel = Microsoft.Office.Interop.Excel;


using Selenium.Pages;

namespace Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Trial()
        {
            //Sudo code for setting us Selenium 

            //1. Create a new instance of Selenium Webdriver

            IWebDriver driver = new ChromeDriver();

            //2. Navigate to the URL 
            driver.Navigate().GoToUrl("https://www.google.com/");
            //3. Maximize the browser 
            driver.Manage().Window.Maximize();

            //Find the element 
            IWebElement webElement = driver.FindElement(By.Id("L2AGLb"));
            webElement.Click();
            IWebElement webElement1 = driver.FindElement(By.Name("q"));

            //4. Type in the element
            webElement1.SendKeys("Selenium");

            //5. Click on the element
            webElement1.SendKeys(Keys.Return);
            driver.Close();
        }

        //[Test]

        //public void EAWebsiteTest()
        //{
        //    //1. Create a new instance of Selenium Webdriver
        //    IWebDriver driver = new ChromeDriver();

        //    //2. Navigate to the URL 
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        //    driver.Manage().Window.Maximize();

        //    //3. Find the login link  and click  the login link 
        //    // driver.FindElement(By.Id("loginLink")).Click();

        //    SeleniumCustomMethods.Click(driver, By.Id("loginLink"));


        //    //Find the Username textbox and send input
        //    // driver.FindElement(By.Name("UserName")).SendKeys("admin");
        //    SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "admin");

        //    //Find the password textbox and send password
        //    // driver.FindElement(By.Id("Password")).SendKeys("password");
        //    SeleniumCustomMethods.EnterText(driver, By.Name("Password"), "password");


        //    // Identify the submit button and click
        //    driver.FindElement(By.ClassName("btn")).Submit();
        //    driver.Close();
        //}
        [Test]
        public void TestWithPOM()
        {
            //1. Create a new instance of Selenium Webdriver
            IWebDriver driver = new ChromeDriver();

            //2. Navigate to the URL 
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // POM initialization
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            loginPage.Login("admin", "password");
            driver.Close();
        }

        


        //[Test]
        //public void WorkingwithAdvacedControls()
        //{
        //    //1. Create a new instance of Selenium Webdriver
        //    IWebDriver driver = new ChromeDriver();

        //    //2. Navigate to the URL 
        //    driver.Navigate().GoToUrl("http://localhost:57406/HTMLPage.html");

        //    driver.Manage().Window.Maximize();
        //    driver.FindElement(By.Id("fname")).SendKeys("test");
        //    driver.FindElement(By.Id("lname")).SendKeys("user");
        //    driver.FindElement(By.Id("html")).Click();
        //    driver.FindElement(By.Id("tool1")).Click();


        //    //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("cars")));
        //    //selectElement.SelectByIndex(2);
        //    SeleniumCustomMethods.SelectDropDownByValue(driver, By.Id("cars"), "saab");

        //    //SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("multiselect")));
        //    //multiSelect.SelectByValue("kingdom");
        //    //multiSelect.SelectByValue("states");

        //    SeleniumCustomMethods.MultiSelectElements(driver, By.Id("multiselect"), ["kingdom", "states"]);

        //    //IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;

        //    //foreach (IWebElement option in selectedOption)
        //    //{
        //    //    Console.WriteLine(option.Text);
        //    //}

        //    var getSelectedOptions = SeleniumCustomMethods.GetAllSelectedLists(driver, By.Id("multiselect"));

        //    //foreach (var selectedOption in getSelectedOptions)
        //    //{
        //    //    Console.WriteLine(selectedOption);

        //    //    
        //    //}
        //    getSelectedOptions.ForEach(Console.WriteLine);
        //}
    }
}