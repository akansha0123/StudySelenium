using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium
{
    public static class SeleniumCustomMethods
    {
        // Method should get locator
        public static void ClickElement(this IWebElement locator)
        {
            // driver.FindElement(locator).Click();    
            locator.Click();
        }
        public static void SubmitElement(this IWebElement locator)
        {
            locator.Submit();
        }
        //Example- SeleniumCustomMethods.Click(driver, By.Id("logiclink");
        public static void EnterText(this IWebElement locator, string text)
        {
           locator.Clear();
            locator.SendKeys(text);
;        }
        public static void SelectDropDownByText(this IWebElement locator, string text)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string value)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByText(value);
        }

        public static void MultiSelectElements(this IWebElement locator, string[] values)
        {
            SelectElement multiSelect = new SelectElement(locator);
            foreach (var value in values)
            {
                multiSelect.SelectByValue(value);
            }
        }
        public static List<string> GetAllSelectedLists(this IWebElement locator)
        {
            List<string> options  = new List<string>();
            SelectElement multiSelect = new SelectElement(locator);
            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;

            foreach (IWebElement option in selectedOption)
            {
               options.Add(option.Text);
            }
            return options;
        }
    }
}
