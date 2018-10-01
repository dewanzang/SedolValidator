using System;
using Sedol.Pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace Sedol.Actions
{
    public class BaseTest: BasePage {
        public HomePage _homePage;
        
        [BeforeScenario]
        public void Setup() {
            Initialize();
            _homePage = new HomePage(driver);            
        }
                
        [AfterScenario]
        public void TearDown() {
            Close();
        }

    }
}
