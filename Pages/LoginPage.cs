using OpenQA.Selenium;

namespace Selenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));

        IWebElement TxtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement TxtPassword => driver.FindElement(By.Id("Password"));

        IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));
        IWebElement LnkEmployeeDetails => driver.FindElement(By.LinkText("Employee Details"));
        IWebElement LnkManageUsers => driver.FindElement(By.LinkText("Manage Users"));
        IWebElement lnkLogoff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin()
        {
            LoginLink.ClickElement();
            //  SeleniumCustomMethods.Click(LoginLink);
        }

        public void Login(string username, string password)
        {
            TxtUserName.Clear();

            TxtUserName.EnterText(username);
            TxtPassword.EnterText(password);
            BtnLogin.SubmitElement();

            //SeleniumCustomMethods.EnterText(TxtUserName, username);
            //SeleniumCustomMethods.EnterText(TxtPassword, password);
            //SeleniumCustomMethods.Submit(BtnLogin);
        }

       public bool IsLoggedIn()
        {
            return LnkEmployeeDetails.Displayed;
        }

    }
}
