using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec.Models
{
    public class Product
    {
        public string ProductInfo(string name)
        {
            return "Name of the product is: " + name;
        }

        public string ProductInfo(string name, int price)
        {
            return "Name of the product is: " + name + " and the price is: " + price;
        }

        public string ProductInfo(string name, int price, int quantity)
        {
            return "name of the product is: "+ name +". the price of the product is: "+price+". the quantity is: "+ quantity+ ". total is: " + (price * quantity);
        }
    }
}
    

   
    // function 1 product
    // function 2 product and price
    // function 3 product price and quantity
   

