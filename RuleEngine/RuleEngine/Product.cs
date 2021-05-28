using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    public enum ProductEnum
    {
        A = 'A',
        B = 'B',
        C = 'C',
        D = 'D',
    }
    public class Product
    {
        public ProductEnum Id { get; set; }
        public decimal Price { get; set; }

        public Product(ProductEnum _id)
        {
            this.Id = _id;
            switch (_id)
            {
                case ProductEnum.A:
                    this.Price = 50;
                    break;
                case ProductEnum.B:
                    this.Price = 30;
                    break;
                case ProductEnum.C:
                    this.Price = 20;
                    break;
                case ProductEnum.D:
                    this.Price = 15;
                    break;
            }
        }

        public static List<Product> getNumOfProducts(ProductEnum _id, string input)
        {
            List<Product> list = new List<Product>();
            int count = 0;
            if(int.TryParse(input, out count))
            {
                for (int i = 0; i < Convert.ToInt32(count); i++)
                {
                    Product product = new Product(_id);
                    list.Add(product);
                }
            }

            return list;
        }
    } 
}
