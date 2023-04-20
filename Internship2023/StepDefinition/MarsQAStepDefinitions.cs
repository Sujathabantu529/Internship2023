using Internship2023.pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Internship2023.Drivers;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Internship2023
{
    [Binding]
    public class MarsQAStepDefinitions : Commondriver

    {


        LoginPage loginPageObj;
        ProfilePage profilePageObj;
        public MarsQAStepDefinitions()
        {
            driver = new ChromeDriver();
            loginPageObj = new LoginPage();
            profilePageObj = new ProfilePage();

        }

        [Given(@"I logged into Mars QA successfully")]
        public void GivenILoggedIntoMarsQASuccessfully()
        {
            //loginpage object initialization and definition
            loginPageObj.LoginActions(driver);


        }

        [When(@"I navigate skills tab and add the skills")]
        public void WhenINavigateSkillsTabAndAddTheSkills()
        {
            //profile page addskills object initialization and definition
            profilePageObj.AddSkills(driver);

        }

        [Then(@"The skills should be added to the profile page successfully")]
        public void ThenTheSkillsShouldBeAddedToTheProfilePageSuccessfully()
        {
            string addedskill = profilePageObj.alertWindow(driver);

            Assert.That(addedskill == "Dance2 has been added to your skills", "Dance2 has not been matched correctly");

        }
        [When(@"I navigate to skills tab and update skills")]
        public void WhenINavigateToSkillsTabAndUpdateSkills()
        {
            profilePageObj.UpdateSkills(driver);
        }

        [Then(@"The skills should be updated to the profile sucessfully")]
        public void ThenTheSkillsShouldBeUpdatedToTheProfileSucessfully()
        {

            string updatedskill = profilePageObj.alertWindow(driver);
            Assert.That(updatedskill == "Dance4 has been updated to your skills", "Dance has not been matched correctly");
        }

        [When(@"I navigate to skills tab and delete skills")]
        public void WhenINavigateToSkillsTabAndDeleteSkills()
        {
            profilePageObj.DeleteSkills(driver);
          
        }


        [Then(@"The skills should be deleted sucessfully")]
        public void ThenTheSkillsShouldBeDeletedSucessfully()
        {

            string deletedskill = profilePageObj.alertWindow(driver);
            Assert.That(deletedskill == "Dance4 has been deleted", "Actual data and expected data do Not match");

        }




    }
}
