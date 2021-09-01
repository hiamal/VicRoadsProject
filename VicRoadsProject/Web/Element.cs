using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VicRoadsCodingChallenge.Web
{
    public class Element
    {
        private string locator;
        private string locatorType;
        
        public Element(string locatorType, string locator)
        {
            this.locator = locator;
            this.locatorType = locatorType;
        }

        public IWebElement findElement()
        {
            switch (locatorType.ToLower())
            {
                case "id":
                    return Browser.Driver.FindElement(By.Id(locator));

                case "class":
                    return Browser.Driver.FindElement(By.ClassName(locator));

                case "name":
                    return Browser.Driver.FindElement(By.Name(locator));

                case "xpath":
                    return Browser.Driver.FindElement(By.XPath(locator));

                default:
                    throw new Exception("Please check locator type - only id, class, name and xpath allowed");
            }
        }

        public string Text
        {
            get => findElement().Text;
            set => findElement().SendKeys(value);
        }

        public void click() => findElement().Click();

        public void select(string text) => new SelectElement(findElement()).SelectByText(text);
    }
}
