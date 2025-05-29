using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelSwagLabs
{
    public class InformationPage : BasePage
    {
        By UserFName = By.Id("first-name");
        By UserLName = By.Id("last-name");
        By PostalCode = By.Id("postal-code");
        By ContinueBtn = By.Id("continue");
        By FinistBtn = By.Id("finish");
        public void UserInformation(string Fname, String Lname , String Postal)
        {
            Write(UserFName, Fname);
            Write(UserLName, Lname);
            Write(PostalCode, Postal);
            Click(ContinueBtn);
            Click(FinistBtn);
        }
    }
}
