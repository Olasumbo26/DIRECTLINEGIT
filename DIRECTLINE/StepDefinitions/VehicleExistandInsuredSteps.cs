using DIRECTLINE.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DIRECTLINE.StepDefinitions
{
    [Binding]
    public class VehicleExistandInsuredSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {

            Hooks1.Driver.Navigate().GoToUrl("https://covercheck.vwfsinsuranceportal.co.uk");
            Hooks1.Driver.Manage().Window.Maximize();

        }

        [When(@"I enter the vehicle registration number")]
        public void WhenIEnterTheVehicleRegistrationNumber()
        {
            Hooks1.Driver.FindElement(By.XPath("//input[@id='vehicleReg']")).SendKeys("OV12UYY");
        }
        
        [When(@"I click on find vehicle")]
        public void WhenIClickOnFindVehicle()
        {
            Hooks1.Driver.FindElement(By.XPath("//span[text()='Find vehicle']")).Click();
        }
        
        [Then(@"i should be able to see if vehicle exists and insured")]
        public void ThenIShouldBeAbleToSeeIfVehicleExistsAndInsured()
        {
            Assert.IsTrue(Hooks1.Driver.FindElement(By.XPath("//div[@class='result']")).Displayed);
        }
    }
}
