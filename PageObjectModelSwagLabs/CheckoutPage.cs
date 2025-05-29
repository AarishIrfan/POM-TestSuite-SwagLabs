using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelSwagLabs
{
    public class CheckoutPage : BasePage
    {
        By CheckOut = By.Id("checkout");

        public void CheckOutItem()
        {
            Click(CheckOut);
        }
    }
}
