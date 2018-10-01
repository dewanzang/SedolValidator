using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecRun.Common.Helper;

namespace Sedol.Pages
{
    public class HomePage: BasePage {

        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "inputBox")]
        private IWebElement inputSedol;

        [FindsBy(How = How.XPath, Using = "(//div[@id='div1']/p/input)[1]")]
        private IWebElement checkBoxIsValidSedol;

        [FindsBy(How = How.XPath, Using = "(//div[@id='div1']/p/input)[2]")]
        private IWebElement checkBoxIsUserDefined;

        [FindsBy(How = How.XPath, Using = "//div[@class='loader']")]
        private IWebElement validationMessageText;
        
        [FindsBy(How = How.Id, Using = "submitSedol")]
        private IWebElement btnSubmit;
        
        public void EnterSedol(String sedol)
        {
            inputSedol.Clear();
            if (!sedol.IsNullOrEmpty())
            {
                inputSedol.SendKeys(sedol);
            }
        }

        public void checkIsValidSedol(bool validSedol)
        {
            if (validSedol)
            {
                checkBoxIsValidSedol.Click();
            }
            else if (checkBoxIsValidSedol.Selected)
                checkBoxIsValidSedol.Click();            
        }

        public void checkIsUserDefined(bool userDefined)
        {
            if (userDefined)
            {
                checkBoxIsUserDefined.Click();
            }
            else if (checkBoxIsUserDefined.Selected)
                checkBoxIsUserDefined.Click();
        }

        public void clickSubmitButton() {
            btnSubmit.Click();
        }

        public string validationMessage()
        {
            string validationMessage = "";

            if (IsElementPresent(By.XPath("//div[@class='loader']"))) {
                validationMessage = validationMessageText.Text;
            }
            
            return validationMessage;
        }

    }
}
