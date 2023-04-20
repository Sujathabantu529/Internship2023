using Internship2023.Drivers;
using Internship2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V110.WebAuthn;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Internship2023.pages
{
    public class ProfilePage

    {



        public void AddSkills(IWebDriver driver)

        {
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10);

            //Navigate to the skills tab

            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();

            //Click on addnew button
            IWebElement addnewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();

            //Identify addskill textbox and enter skill
            IWebElement addskilltextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskilltextbox.SendKeys("Dance2");

            //Select skill level from choose skill level dropdown
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 10);
            IWebElement skillleveldropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillleveldropdown.Click();

            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]", 10);
            IWebElement expertoption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            expertoption.Click();

            //Click on add button 
            IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addbutton.Click();



        }
       // public string GetaddedText(IWebDriver driver)
       // {
           // IWebElement actualText = driver.FindElement(By.XPath("/html/body/div[1]/div"));
           // Console.WriteLine(actualText);
           // return actualText.Text;

       // }

       // public string Getaddedskill(IWebDriver driver)
       // {
           // IWebElement addedskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            //return addedskill.Text;

       // }
        //public string Getaddedskilllevel(IWebDriver driver)
        //{
        //    IWebElement addedskilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        //    return addedskilllevel.Text;

        //}



        public void UpdateSkills(IWebDriver driver )
        {

            //Navigate to the skills tab
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();


            //click on skills edit icon
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10);
            IWebElement editicon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editicon.Click();

            //edit new skill into the skill textbox
            IWebElement editnewskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editnewskill.Click();
            editnewskill.Clear();
            editnewskill.SendKeys("Dance4");

            //edit new skill level into the skill level dropdown
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 10);
            IWebElement skillleveldropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            skillleveldropdown.Click();


            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]", 10);
            IWebElement beginneroption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            beginneroption.Click();

            //click on update button
            IWebElement updatebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updatebutton.Click();




        }
        //public string GetUpdateSkill(IWebDriver driver)
        //{
        //    IWebElement CreatedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        //    return CreatedSkill.Text;

        //}
        //public string GeUpdateSkilllevel(IWebDriver driver)
        //{
        //    IWebElement CreatedSkilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        //    return CreatedSkilllevel.Text;

        //}

        public void DeleteSkills(IWebDriver driver)
        {
            //Navigate to the skills tab
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();

            //click on skills delete button
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 10);
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deletebutton.Click();
        }
        //public string GetText(IWebDriver driver)
        //{
        //    IWebElement actualText = driver.FindElement(By.XPath("/html/body/div[1]/div"));
        //    Console.WriteLine(actualText);
        //    return actualText.Text;

        //}

        public string alertWindow(IWebDriver driver)
        {

            Wait.WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            Console.WriteLine("Actual text captured is:" + confirmationAlert.Text);
            return confirmationAlert.Text;


           
            

        }
    
    }
    
}
