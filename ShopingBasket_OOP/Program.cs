using System;

namespace ShopingBasket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.CustomerName = "Thomas";

            Candy chokoBar = new Candy();

            chokoBar.Type = "";
            chokoBar.ProductName = "";
            chokoBar.ProductPrice = 12.99;

            Cloth cloth = new Cloth()
            {
                Color = "red",
                Size = 2,
                ProductName = "Dress",
                ProductPrice = 200.12
            };
            Basket basket = new Basket();
            basket.productList.Add(cloth);

            foreach (Cloth product in basket.productList)
            {
                Console.WriteLine(product.ToString());
            }
           
        }
    }
}
