using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PageObjectModelSwagLabs
{
    [TestClass]
    public class Execution : BasePage
    {
        [TestMethod]
        public void TestCase001()
        {
           
            BasePage.SeleniumInit();
            Login login = new Login();
            login.login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
        }
        [TestMethod]
        public void TestCase002()
        {
            BasePage.SeleniumInit();
            Login login = new Login();
            login.login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            ProductPage Products = new ProductPage();
            Products.Products();
        }
        [TestMethod]
        public void TestCase003()
        {
            BasePage.SeleniumInit();
            Login login = new Login();
            login.login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            ProductPage Products = new ProductPage();
            Products.Products();
            CheckoutPage checkoutPage = new CheckoutPage();
            checkoutPage.CheckOutItem();
        }
        [TestMethod]
        public void TestCase004()
        {
            BasePage.SeleniumInit();
            Login login = new Login();
            login.login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            ProductPage Products = new ProductPage();
            Products.Products();
            CheckoutPage checkoutPage = new CheckoutPage();
            checkoutPage.CheckOutItem();
            InformationPage Message = new InformationPage();
            Message.UserInformation("Aarish","Irfan" , "75280");
        }
    }
}
