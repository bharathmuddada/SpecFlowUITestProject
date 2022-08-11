using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Infrastructure;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class DemoBlazeStepDefinitions
    {
        string test_url = "https://www.demoblaze.com/";
        IWebDriver driver = new ChromeDriver(@"C:\\Demo\\SpecFlowProject\\SpecFlowProject\\Drivers");


    
        [Given(@"I Navigate to ""([^""]*)"" Section")]
        public void GivenINavigateToSection(string sectionName)
        {
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (sectionName == "Phones")
                driver.FindElement(By.XPath("//a[text()='Phones']")).Click();
            else if (sectionName == "Laptops")
                driver.FindElement(By.XPath("//a[text()='Laptops']")).Click();

        }

        [When(@"I click on the ""([^""]*)"" item")]
        [Then(@"I click on the ""([^""]*)"" item")]
        public void WhenIClickOnTheItem(string itemName)
        {
       
            driver.FindElement(By.XPath($"//a[text()='{itemName}']")).Click();

            
        }

        [Then(@"header name of the item should be equal to the item selected")]
        public void ThenHeaderNameOfTheItemShouldBeEqualToTheItemSelected()
        {
            string headerelementtext = driver.FindElement(By.XPath("//h2[@class='name']")).Text;

            headerelementtext.Should().Be("Sony vaio i6");

            
            driver.Quit();
        }
    }
}


