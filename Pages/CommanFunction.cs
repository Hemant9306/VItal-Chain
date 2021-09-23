using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace GameTwist.Pages
{
    class CommanFunction : Driver
    {
/*        IWebDriver _driver;
        public CommanFunction(IWebDriver driver)
        {
            _driver = driver;
        }*/

        public static string NameV;

        //IWebDriver driver;
        By homePage = By.XPath("//*[@title='GameTwist Online Casino']");
        By searchGame = By.XPath("//*[@class='c-search__box']");
        IList<IWebElement> lstgames => driver.FindElements(By.XPath("//li[contains(@class,'c-game-list__item')]"));
        IWebElement Registbtn => driver.FindElement(By.XPath("//*[@class='c-header__subgrid']/a[contains(text(),'Register')]"));
        IWebElement Loginbtn => driver.FindElement(By.XPath("//*[@class='c-header__subgrid']/a[contains(text(),'Login')]"));
        IWebElement actpCookies => driver.FindElement(By.XPath("//*[@title='Accept All Cookies']"));

        IWebElement regEmail => driver.FindElement(By.XPath("//*[contains(text(),'Please enter a valid e-mail address')]"));
        IWebElement NickName => driver.FindElement(By.XPath("//*[contains(text(),'Please enter a valid nickname')]"));
        IWebElement regPasssword => driver.FindElement(By.XPath("//*[contains(text(),'Your password must be at least 8 characters long')]"));
        IWebElement CaptchA => driver.FindElement(By.XPath("//*[@id='recaptcha-anchor-label']"));
        IWebElement terms => driver.FindElement(By.XPath("//*[@for='termsAccept']"));


        IWebElement emailError => driver.FindElement(By.XPath("//*[contains(text(),'E-mail address required')]"));
        IWebElement NickNameError => driver.FindElement(By.XPath("//*[contains(text(),'Nickname required')]"));
        IWebElement PasswrdError => driver.FindElement(By.XPath("//*[contains(text(),'Password required')]"));
        IWebElement TermCond => driver.FindElement(By.XPath("//*[contains(text(),'The security check is a required field. Please enter the code')]"));

        IWebElement BeginBtn => driver.FindElement(By.XPath("//*[contains(text(),'Begin adventure')]"));

        IWebElement emailTxt => driver.FindElement(By.XPath("//*[@name='email']"));
        IWebElement NickText => driver.FindElement(By.XPath("//*[@name='nickname']"));
        IWebElement PasswrdTxt => driver.FindElement(By.XPath("//*[@name='password']"));
        IWebElement Security => driver.FindElement(By.XPath("//*[@class='recaptcha-checkbox-border']"));

        IWebElement inputday => driver.FindElement(By.XPath("//*[@name='day']"));
        IWebElement inputmonth => driver.FindElement(By.XPath("//*[@name='month']"));
        IWebElement inputyear => driver.FindElement(By.XPath("//*[@name='year']"));


        IWebElement TxtNickName => driver.FindElement(By.XPath("//*[@name='username']"));
        IWebElement TxtPasswrd => driver.FindElement(By.XPath("//*[@name='password']"));

        string InvalidEmail = "a@abc";
        string ValidEmail = "a@abc.com";
        string nickName = "hems5847895";
       // string ValidEmail = "a@abc.com";

        public bool EnterRegistrationData()
        {
            try
            {
                enterData(emailTxt, ValidEmail);
                enterData(NickText, nickName);
                enterData(PasswrdTxt, "Hemant@1234");
                drpdwnvalue();
                clickBtn(Security); // can not click using selenium 
                clickBtn(terms);
                ClickOnRegistrationBtn();
                return true;
            }
            catch (Exception)
            {

                Console.WriteLine("Enetr Valid data");
                return false;
            }
        }

        public void drpdwnvalue()
        {
            SelectElement selectday = new SelectElement(inputday);
            SelectElement selectmonth = new SelectElement(inputmonth);
            SelectElement selectyear = new SelectElement(inputyear);


            selectday.SelectByValue("27");
            selectmonth.SelectByValue("12");
            selectyear.SelectByValue("1987");

        }


        public void enterInvalidEmail()
        {
            try
            {
                enterData(emailTxt, InvalidEmail);
            }
            catch (Exception)
            {

                Console.WriteLine("Enetr Valid data");
            }
        }

        public bool checkInvalidEmailError()
        {
            try
            {
                if(regEmail.Displayed)
                {
                    return true;
                }
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void enterData(IWebElement element,string data)
        {
            try
            {
                element.SendKeys(data);
            }catch
            {

            }
        }

        public bool ClickOnBeginBtn()
        {
           try
            {
                clickBtn(BeginBtn);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ClickOnloginBtn()
        {
            try
            {
                clickBtn(Loginbtn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool IsloginPageDispl()
        {
            try
            {
                if(TxtNickName.Displayed & TxtPasswrd.Displayed)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EnterLogData()
        {
            try
            {
                enterData(TxtNickName, "Hemant123");
                enterData(TxtPasswrd, "Hemant@5123");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChkSearchBox()
        {
            try
            {
                if (IsDisp(searchGame))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool CheckPageDisplayed()
        {
            try
            {
                Thread.Sleep(5000);
                ClickNotifWindow();
                if (IsDisp(homePage))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ClickNotifWindow()
        {
            try
            {
                InputSimulator sim = new InputSimulator();
                sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            }
            catch (Exception)
            {

                throw;
            }
        }

/*        public void ClickLoginWindow()
        {
            try
            {
                InputSimulator sim = new InputSimulator();
                sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                sim.Keyboard.KeyPress(VirtualKeyCode.ACCEPT);
            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public bool EnterUrl(string Url)
        {
            try
            {
                driver.Navigate().GoToUrl(Url);

                // Thread.Sleep(5000);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool CheckGameMenu(string MenuItem)
        {
            try
            {
                IList <IWebElement> lstMen = driver.FindElements(By.XPath("//li[@class='o-nav__item']/a"));
                //By lstItme = By.XPath(""); 
                
                for(int i=0;i<lstMen.Count;i++)
                {
                    if (lstMen[i].Text.Equals(MenuItem)) 
                    {
                        return true;
                    }
                }

                return false;
            }catch(Exception ex)
            {
                return false;
            }
        }



        public bool ClickOnGameMenu(string MenuItem)
        {
            try
            {
                IList<IWebElement> lstMen = driver.FindElements(By.XPath("//li[@class='o-nav__item']/a"));
                //By lstItme = By.XPath(""); 

                for (int i = 0; i < lstMen.Count; i++)
                {
                    if (lstMen[i].Text.Equals(MenuItem))
                    {
                        lstMen[i].Click();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool ClickOnRegistrationBtn()
        {
            try
            {
                if(clickBtn(Registbtn))
                {
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }

        public void AcptCookies()
        {
            try
            {
                Thread.Sleep(2000);
                if (actpCookies.Displayed)
                {
                    clickBtn(actpCookies);
                }
            }
            catch (Exception)
            {
                // do nothing
            }
        }

        public bool checkText()
        {
            try
            {
                //& NickName.Displayed & regPasssword.Displayed &  CaptchA.Displayed & terms.Displayed)
                if (regEmail.Displayed & NickName.Displayed)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool checkErrorText()
        {
            try
            {
                Thread.Sleep(2000);
                if (emailError.Displayed && NickNameError.Displayed && TermCond.Displayed && PasswrdError.Displayed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool clickBtn(IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool listCount()
        {
            if(lstgames.Count>0)
            {
                return true;
            }else
            {
                return false;
            }
        }




        public bool CheckLoginAndRegister(string MenuItem)
        {
            try
            {
                IList<IWebElement> lstMen = driver.FindElements(By.XPath("//*[@class='c-header__subgrid']/a"));

                for (int i = 0; i < lstMen.Count; i++)
                {
                    if (lstMen[i].Text.Equals(MenuItem)) 
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsDisp(By element , int TimeOut=2)
        {
            bool flag = false;
            for(int i=0;i<TimeOut;i++)
            {
                try
                {
                    if(driver.FindElement(element).Displayed)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    }
                }
                catch(Exception)
                {

                }
            }
            return flag;
        }


        /////////////////////////////////
        ///

        public static string Name()
        {
            NameV = DateTime.Now.ToString("yyyyMMddHHmmss");
            return NameV;
        }

        public bool PostLoginAPI()
        {
            string url = "https://petstore.swagger.io/v2/user";
            var timeString1 = DateTime.Now.ToString("yyyyMMddHHmmss");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                

                JObject obj = new JObject(
                    new JProperty ("id", timeString1),
                    new JProperty("username", Name()),
                    new JProperty("firstName", "Hemant"),
                    new JProperty("lastName", "Talavdekar"),
                    new JProperty("email", "a@ca.com"), 
                    new JProperty("password", "Hmenat@123"),
                    new JProperty("phone", "8007706848"),
                    new JProperty("userStatus", "0"));

                try
                {
                    var content = new StringContent(obj.ToString(),Encoding.UTF8,"application/json");

                    HttpResponseMessage webresponse = client.PostAsync(new Uri(url), content).Result;

                    if(webresponse.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }



        public bool GetUserAPI()
        {
            string url = "https://petstore.swagger.io/v2/user/" +NameV;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                //not getting updated quickly
                Thread.Sleep(10000);
                try
                {
                    HttpResponseMessage webresponse = client.GetAsync(new Uri(url)).Result;

                    if (webresponse.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool GetUserAPIError()
        {
            string url = "https://petstore.swagger.io/v2/user/LAKAL";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                try
                {
                    HttpResponseMessage webresponse = client.GetAsync(new Uri(url)).Result;

                    if (webresponse.StatusCode.Equals(HttpStatusCode.NotFound))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool DeleteUserAPI()
        {
            string url = "https://petstore.swagger.io/v2/user/" + NameV;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                Thread.Sleep(5000);
                try
                {
                    HttpResponseMessage webresponse = client.DeleteAsync(new Uri(url)).Result;

                    if (webresponse.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool PutUserAPI()
        {
            string url = "https://petstore.swagger.io/v2/user/" + NameV;
            var timeString1 = DateTime.Now.ToString("yyyyMMddHHmmss");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();


                JObject obj = new JObject(
                    new JProperty("id", timeString1),
                 //   new JProperty("username", Name()),
                    new JProperty("firstName", "Hemant"),
                    new JProperty("lastName", "Talavdekar"),
                    new JProperty("email", "a@ca.com"),
                    new JProperty("password", "Hmenat@123"),
                    new JProperty("phone", "8007706848"),
                    new JProperty("userStatus", "0"));

                try
                {
                    var content = new StringContent(obj.ToString(), Encoding.UTF8, "application/json");

                    HttpResponseMessage webresponse = client.PutAsync(new Uri(url), content).Result;

                    if (webresponse.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
