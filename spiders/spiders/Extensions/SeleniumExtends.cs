using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiders.Extensions
{
    public static class SeleniumExtends
    {
        public static IWebElement TryFindElement(this IWebElement WebElement, By by)
        {
            try
            {
                return WebElement.FindElement(by);
            }
            catch
            {
                return null;
            }
        }
    }
}
