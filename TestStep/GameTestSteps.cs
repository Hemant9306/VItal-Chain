using GameTwist.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace GameTwist.TestStep
{
    [Binding]
    public class GameTestSteps
    {
        Driver Dcls = new Driver();
        CommanFunction comman = new CommanFunction();

        [Given(@"Launch game url")]
        public void GivenLaunchGameUrl()
        {
            Dcls.launchBrowser();
        }

        [When(@"Get Game Home Page")]
        public void WhenGetGameHomePage()
        {
            comman.CheckPageDisplayed();
        }

        [Then(@"Check HomePage UI Validation")]
        public void ThenCheckHomePageUIValidation()
        {
            Assert.IsTrue(comman.CheckGameMenu("SLOTS"));
            Assert.IsTrue(comman.CheckGameMenu("CASINO"));
            Assert.IsTrue(comman.CheckGameMenu("POKER"));
            Assert.IsTrue(comman.CheckGameMenu("BINGO"));
            Assert.IsTrue(comman.CheckGameMenu("SKILL"));
            Assert.IsTrue(comman.ChkSearchBox());
            Assert.IsTrue(comman.CheckLoginAndRegister("LOGIN"));
            Assert.IsTrue(comman.CheckLoginAndRegister("REGISTER"));
        }


        [Then(@"Check Games loaded as per menu items")]
        public void ThenCheckGamesLoadedAsPerMenuItems()
        {
            Assert.IsTrue(comman.CheckGameMenu("SLOTS"));
            Assert.IsTrue(comman.ClickOnGameMenu("SLOTS"));
            Assert.IsTrue(comman.listCount());

            Assert.IsTrue(comman.CheckGameMenu("CASINO"));
            Assert.IsTrue(comman.ClickOnGameMenu("CASINO"));
            Assert.IsTrue(comman.listCount());

            Assert.IsTrue(comman.CheckGameMenu("POKER"));
            Assert.IsTrue(comman.ClickOnGameMenu("POKER"));
            Assert.IsTrue(comman.listCount());

            Assert.IsTrue(comman.CheckGameMenu("BINGO"));
            Assert.IsTrue(comman.ClickOnGameMenu("BINGO"));
            Assert.IsTrue(comman.listCount());

            Assert.IsTrue(comman.CheckGameMenu("SKILL"));
            Assert.IsTrue(comman.ClickOnGameMenu("SKILL"));
            Assert.IsTrue(comman.listCount());
        }


        [Then(@"Check Registration Page Validation")]
        public void ThenCheckRegistrationPageValidation()
        {
            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            Assert.IsTrue(comman.checkText());
        }

        [Then(@"Validate details for registration page")]
        public void ThenValidateDetailsForRegistrationPage()
        {
            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            comman.ClickOnBeginBtn();
            Assert.IsTrue(comman.checkErrorText());
        }

        [Then(@"Check Invalid data for email")]
        public void ThenCheckInvalidDataForEmail()
        {
            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            comman.enterInvalidEmail();

            Assert.IsTrue(comman.checkInvalidEmailError());
        }


        [Then(@"Enter registration details")]
        public void ThenEnterRegistrationDetails()
        {

            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            Assert.IsFalse(comman.EnterRegistrationData());
        }

        [Then(@"Check Login button UI Validation")]
        public void ThenCheckLoginButtonUIValidation()
        {
            Assert.IsTrue(comman.ClickOnloginBtn());
            Assert.IsTrue(comman.IsloginPageDispl());
        }

        [Then(@"Enter Login data")]
        public void ThenEnterLoginData()
        {
            Assert.IsTrue(comman.ClickOnloginBtn());
            Assert.IsTrue(comman.EnterLogData());
        }

    }
}
