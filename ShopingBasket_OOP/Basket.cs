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
        Cloth cloth = new Cloth();
        public double TotalResult()
        {
            foreach (Cloth cPrice in clothList)
            {
                clothSum =+ cPrice.ProductPrice;
            }
            return clothSum;
            
        }
        
        
    }
}
