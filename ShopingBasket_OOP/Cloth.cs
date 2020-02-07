using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingBasket_OOP
{
    class Cloth:Product// nedarver fra product klassen
    {
        private string color;
        private int size;

        public string Color { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Size { get; set; }

        
        public Cloth()
        {

        }
        
    }
}
