using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingBasket_OOP
{
    class Customer
    {
        private string customerName;
        
        public string CustomerName { get; set; }
        public string PrintCustomer()
        {
            return customerName;
        } 
    }
}
