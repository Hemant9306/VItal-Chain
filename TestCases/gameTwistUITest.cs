using GameTwist.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwist.TestCases
{
    class gameTwistUITest :Driver
    {        

        [Test]
        [Order(0)]
        public void HomePageUITest()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());
            Assert.IsTrue(comman.CheckGameMenu("SLOTS"));
            Assert.IsTrue(comman.CheckGameMenu("CASINO"));
            Assert.IsTrue(comman.CheckGameMenu("POKER"));
            Assert.IsTrue(comman.CheckGameMenu("BINGO"));
            Assert.IsTrue(comman.CheckGameMenu("SKILL"));
            Assert.IsTrue(comman.ChkSearchBox());
            Assert.IsTrue(comman.CheckLoginAndRegister("LOGIN"));
            Assert.IsTrue(comman.CheckLoginAndRegister("REGISTER"));
        }


        [Test]
        [Order(1)]
        public void CheckGamesLoaded()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());
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
        [Test]
        [Order(2)]
        public void ValidateUIForRegistrationPage()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());

            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            Assert.IsTrue(comman.checkText());
        }

        [Test]
        [Order(3)]
        public void ValidateDetailsForRegistrationPage()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());

            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            comman.ClickOnBeginBtn();
            Assert.IsTrue(comman.checkErrorText());
        }

        [Test]
        [Order(4)]
        public void InValidEmailOnRegitrationForm()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());

            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            comman.enterInvalidEmail();

            Assert.IsTrue(comman.checkInvalidEmailError());
        }

        [Test]
        [Order(5)]
        public void EnterRegistration()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.CheckPageDisplayed());

            Assert.IsTrue(comman.ClickOnRegistrationBtn());
            comman.AcptCookies();
            Assert.IsFalse(comman.EnterRegistrationData());

        }

        [Test]
        [Order(6)]
        public void LoginButtonTest()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());
            Assert.IsTrue(comman.ClickOnloginBtn());
            Assert.IsTrue(comman.IsloginPageDispl());

        }


        [Test]
        [Order(7)]
        public void LoginDataTest()
        {
            CommanFunction comman = new CommanFunction();

            Assert.IsTrue(comman.CheckPageDisplayed());
            Assert.IsTrue(comman.ClickOnloginBtn());
            Assert.IsTrue(comman.EnterLogData());

        }

    }
}
