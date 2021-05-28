using System;
using System.Collections.Generic;

namespace RuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                List<Product> products = new List<Product>();

                foreach (ProductEnum item in (ProductEnum[])Enum.GetValues(typeof(ProductEnum)))
                {
                    Console.WriteLine("How many products of type '" + item.ToString() + "'");
                    string input = Console.ReadLine();

                    products.AddRange(Product.getNumOfProducts(item, input));
                }

                PromotionService promotionService = new PromotionService();
                decimal totalValue = promotionService.getTotalValue(products);
                Console.WriteLine("Total Order Value : " + totalValue);

                Console.WriteLine("Do you want to repeat the Transaction y/n");

                string response = Console.ReadLine();

                if(response == "N" || response == "n")
                {
                    repeat = false;
                }
            }
            
        }
    }
}
