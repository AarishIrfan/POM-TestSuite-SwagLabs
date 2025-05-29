using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelSwagLabs
{
    public class ProductPage : BasePage
    {
        By AddtoCart = By.Id("add-to-cart-sauce-labs-backpack");
        By ShoppingCart = By.Id("shopping_cart_container");
        public void Products()
        {
            Click(AddtoCart);
            Click(ShoppingCart);
        }
    }
   
}
