using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingBasket_OOP
{
    class Basket
    {
        //public string Name { get; set; }
        double clothSum;
        public List<Cloth> clothList = new List<Cloth>();
        public List<Candy> candyList = new List<Candy>();
        public double TotalResult()
        {
            foreach (Cloth cPrice in clothList)
            {
                clothSum =+ cPrice.ProductPrice;
            }
            foreach (Candy c in candyList)
            {
                clothSum += c.ProductPrice;
            }
            return Math.Round(clothSum);
            
        }
        
        
    }
}
