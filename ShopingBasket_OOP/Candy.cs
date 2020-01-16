using System;
using System.Collections.Generic;
using System.Text;
using static ShopingBasket_OOP.Product;

namespace ShopingBasket_OOP
{
    class Candy: Product
    {
        private string type;

        public string Type { get; set; }
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }
        public Candy()
        {

        }
        
    }
}
