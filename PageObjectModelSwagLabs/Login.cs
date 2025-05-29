using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelSwagLabs
{
  public  class Login : BasePage
    {
        By Username = By.Id("user-name");
        By Password = By.Id("password");
        By LoginBtn = By.Id("login-button");

        public void login(string url , string user , string pass)
        {
            driver.Url = url;
            Write(Username, user);
            Write(Password, pass);
            Click(LoginBtn);
        }



    }
}
