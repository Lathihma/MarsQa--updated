using NUnitTestProject3.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject3.features
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginpage = null;
        Language language = null;
        SkillsTab skillstab = null;

        [Given(@"launch the application")]
        public void GivenLaunchTheApplication()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            loginpage = new LoginPage(webdriver);
        }
        
        [Given(@"Click on login button")]
        public void GivenClickOnLoginButton()
        {
            loginpage.ClickLogin();
        }
        
        [Given(@"Enter the following details")]
        public void GivenEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.Emailaddress, (string)data.Password);
        }
        
        [Given(@"click on login button")]
        public void GivenClickOnLoginButtonAgain()
        {
            loginpage.ClickLoginButton();
        }
        
        [Given(@"To enter the languages set tab")]
        public void GivenToEnterTheLanguagesSetTab()
        {
            language.ClickLanguage();
        }
        
        [Given(@"when you enter add feature for language")]
        public void GivenWhenYouEnterAddFeatureForLanguage()
        {
            language.clickAdd();

        }
        [When(@"you choose the option and click on add")]
        public void WhenYouChooseTheOptionAndClickOnAdd(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            language.Add1((string)data.language, (string)data.level);
        }

        [Then(@"details will be saved")]
        public void ThenDetailsWillBeSaved()
        {
            language.clickAddButton();
        }

        [Given(@"To enter the skill set form")]
        public void GivenToEnterTheSkillSetForm()
        {
            skillstab.ClickSkill();
        }
        
        [Given(@"I click on add New button")]
        public void GivenIClickOnAddNewButton()
        {
            skillstab.AddNew(); ;
        }
        
        [Given(@"I fill the details under the skill tab")]
        public void GivenIFillTheDetailsUnderTheSkillTab(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            skillstab.Add1((string)data.skill, (string)data.level);

        }

       
        
        [When(@"you click on add button for skills")]
        public void WhenYouClickOnAddButtonForSkills()
        {
            skillstab.AddBTN();
        }
        
   
    }
}
