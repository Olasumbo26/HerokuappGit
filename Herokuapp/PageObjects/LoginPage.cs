using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herokuapp.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Herokuapp.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement userName { get; set; }

        public void Enterusername(string usernametext)
        {
            userName.SendKeys(usernametext);
        }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passWord { get; set; }

        public void Enterpassword(string passwordtext)
        {
            passWord.SendKeys(passwordtext);
        }
        [FindsBy(How = How.CssSelector, Using = "#login > button")]
        private IWebElement login { get; set; }

        public void Clicklogin()
        {
            login.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#flash")]
        private IWebElement flashsuccess { get; set; }

        public bool flashSuccessIsDisplayed()
        {
            return flashsuccess.Displayed;
        }
        [FindsBy(How = How.PartialLinkText, Using = "Logout")]
        private IWebElement logout { get; set; }

        public void Clicklogout()
        {
            logout.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='flash'")]
        private IWebElement UserNameIsInvalidMessage { get; set; }

        public bool YourUserNameIsInvalidMessageIsDisplayed()
        {
            
            {
                return UserNameIsInvalidMessage.Displayed;
            }
           

             













        }

    }
}
