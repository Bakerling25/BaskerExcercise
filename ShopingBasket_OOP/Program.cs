using System;

namespace ShopingBasket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.CustomerName = "Thomas";

            Candy chokoBar = new Candy()
            {
                Type = "Chocolate",
                ProductName = "MyBAR",
                ProductPrice = 12.99
            };

            

            Cloth cloth = new Cloth()
            {
                Color = "red",
                Size = 2,
                ProductName = "Dress",
                ProductPrice = 200.12
            };
            Cloth cloth2 = new Cloth()
            {
                Color = "blue",
                Size = 5,
                ProductName = "Shorts",
                ProductPrice = 502.93
            };
            Basket basket = new Basket();
            basket.clothList.Add(cloth);
            basket.clothList.Add(cloth2);

            foreach (Cloth product in basket.clothList)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Size.ToString());
                Console.WriteLine(product.Color);
                //Console.WriteLine(basket.TotalResult().ToString());
            }
            Console.WriteLine(basket.TotalResult().ToString());
            Console.ReadLine();
        }
    }
}
