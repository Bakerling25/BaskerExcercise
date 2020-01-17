using System;

namespace ShopingBasket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Basket basket = new Basket();
            customer.CustomerName = "Thomas";

            Candy chokoBar = new Candy()
            {
                Type = "Chocolate",
                ProductName = "Chokofant",
                ProductPrice = 12.99
            };
            basket.candyList.Add(chokoBar);
            

            Cloth cloth = new Cloth()
            {
                Color = "red",
                Size = 2,
                ProductName = "Dress",
                ProductPrice = 199.25
            };
            Cloth cloth2 = new Cloth()
            {
                Color = "blue",
                Size = 5,
                ProductName = "Shorts",
                ProductPrice = 499.95
            };
            
            basket.clothList.Add(cloth);
            basket.clothList.Add(cloth2);

            Console.WriteLine(customer.CustomerName);
            foreach (Cloth c in basket.clothList)
            {
                Console.WriteLine(c.ProductName + ":     ProductName");
                Console.WriteLine(c.Size.ToString() + ":     Size");
                Console.WriteLine(c.Color);
                Console.WriteLine(c.ProductPrice.ToString() + " kr");
                Console.WriteLine("_________________________________________");
            }
            foreach (Candy c in basket.candyList)
            {
                Console.WriteLine(c.ProductName);
                Console.WriteLine(c.ProductPrice.ToString() + " kr");
                Console.WriteLine("_________________________________________");
            }
            Console.WriteLine("Total Amount: "+ basket.TotalResult().ToString() + " kr");
            Console.ReadLine();
        }
    }
}
