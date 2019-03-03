using System;
using System.Threading;
using Herokuapp.PageObjects;
using Herokuapp.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Herokuapp.StepDefinitions
{
    [Binding]
    public class LoginStep
    {
        LoginPage Login;
        public LoginStep()

        {
            Login = new LoginPage();
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
            Hooks.Driver.Manage().Window.Maximize();

        }

    
        [When(@"I enter Username")]
        public void WhenIEnterUsername()
        {
          Login.Enterusername("tomsmith");
        }


        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            Login.Enterpassword("SuperSecretPassword!");
        }
        
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            Login.Clicklogin();
        }
        
        [Then(@"i am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            Assert.IsTrue(Login.flashSuccessIsDisplayed());

        }
        [Then(@"I click log out")]
        public void ThenIClickLogOut()
        {
            Login.Clicklogout();
        }

        [When(@"I enter username""(.*)""")]
        public void WhenIEnterUsername(string usernameEntered)
        {
            Login.Enterusername(usernameEntered);
        }

        [Then(@"Your username is invalid is Displayed")]
        public void ThenYourUsernameIsInvalidIsDisplayed()
        {
            Assert.IsTrue(Login.flashSuccessIsDisplayed(), "Error Message: Login Failed");
            

        }

    }

}
