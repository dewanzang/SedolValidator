using System;
using TechTalk.SpecFlow;
using Sedol.Actions;
using System.Configuration;
using NUnit.Framework;
using TechTalk.SpecRun.Common.Helper;

namespace Sedol.Steps
{
    [Binding]
    public class SedolValidationCheckSteps: BaseTest
    {
        private string _baseUrl;

        [Given(@"User is at the Sedol Web App Home Page")]
        public void GivenUserIsAtTheSedolWebAppHomePage()
        {
            _baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            NavigateToURL(_baseUrl);
        }
        
        [When(@"User enter InputString Test Value in Sedol input field '(.*)'")]
        public void WhenUserEnterInputStringTestValueInSedolInputField(String sedol)
        {
            _homePage.EnterSedol(sedol);
        }
        
        [When(@"User enter InputString Test Value in Sedol input field null")]
        public void WhenUserEnterInputStringTestValueInSedolInputFieldNull()
        {
            _homePage.EnterSedol(null);
        }

        [When(@"User enter InputString Test Value in Sedol input field ""(.*)""")]
        public void WhenUserEnterInputStringTestValueInSedolInputFieldEmptyString(String sedol)
        {
            _homePage.EnterSedol(sedol);
        }

        [When(@"Select Is Valid Sedol (true|false)")]
        public void WhenSelectIsValidSedol(Boolean IsValidSedol)
        {
            _homePage.checkIsValidSedol(IsValidSedol);
        }
        
        [When(@"Select Is User Define (true|false)")]
        public void WhenSelectIsUserDefine(Boolean IsUserDefined)
        {
            _homePage.checkIsUserDefined(IsUserDefined);
            _homePage.clickSubmitButton();
        }

        [Then(@"the correct Validation Details is displayed '(.*)'")]
        public void ThenTheCorrectValidationDetailsIsDisplayed(String expectedValidationMessage)
        {
            String actualValidationMessage = _homePage.validationMessage();
            Assert.AreEqual(actualValidationMessage, expectedValidationMessage);
        }

        [Then(@"the correct Validation Details is displayed null")]
        public void ThenTheCorrectValidationDetailsIsDisplayedNull()
        {
            String actualValidationMessage = _homePage.validationMessage();
            Assert.True(actualValidationMessage.IsNullOrWhiteSpace());
        }

        [Then(@"the correct Validation Details is displayed ")]
        public void ThenTheCorrectValidationDetailsIsDisplayed()
        {
            String actualValidationMessage = _homePage.validationMessage();
            Assert.True(actualValidationMessage.IsNullOrEmpty());
        }

    }
}
