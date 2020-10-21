



using System;
using System.Collections.Generic;

namespace Week6CheckoutExercise
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(string Name, double Price)
        {
            ProductName = Name;
            ProductPrice = Price;
        }
    }
    
    class CheckOutSystem
    {
        public List<Product> ProductList { get; set; }

        public CheckOutSystem(List<Product> ListOfProduct)
        {
            ProductList = ListOfProduct;
        }

        public double TotalPrice()
        {
            double Result = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                Result += ProductList[i].ProductPrice;
            }
            return Result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Product Apple = new Product("Apple", 0.60) ;
            Product Orange = new Product("Orange", 0.25);
            List<Product> ListToBuy = new List<Product>();
            ListToBuy.Add(Apple);
            ListToBuy.Add(Orange);
            ListToBuy.Add(Orange);
            ListToBuy.Add(Apple);
            CheckOutSystem Check1 = new CheckOutSystem(ListToBuy);

            Console.WriteLine("Total price : " + Check1.TotalPrice());
            Console.ReadLine();
        }
    }
}
