using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship2023.Utilities;
using Internship2023.Drivers;
using OpenQA.Selenium.Support.UI;

namespace Internship2023.pages
{
    public class LoginPage 
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch MarsQA Website
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Navigate to signin button and click on it
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 10);
            IWebElement signinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinbutton.Click();

            //Identify email address textbox and enter the valid email address
            Wait.WaitTobeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 10);
            IWebElement emailaddersstextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddersstextbox.Click();
            emailaddersstextbox.SendKeys("sujathabantu529@gmail.com");

            //Identify passwordtextbox and enter the valid password
            IWebElement passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordtextbox.SendKeys("Avira@3451");

            //Click on login button
            IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);




        }
        public string alertWindow(IWebDriver driver)
        {

            Wait.WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}
