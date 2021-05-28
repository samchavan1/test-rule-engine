using NUnit.Framework;
using RuleEngine;
using System;
using System.Collections.Generic;

namespace RuleEngineTest
{
    [TestFixture]
    public class RuleTest
    {
        // A - 3 B - 0 C- 0 D- 0 = 130
        [Test]
        public void Test1()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "3"));

            PromotionService productService = new PromotionService();
            decimal totalVal =  productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 130M);
        }

        // A - 0 B - 0 C- 1 D- 1 = 30
        [Test]
        public void Test2()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 30M);
        }

        // A - 1 B - 1 C- 1 D- 0 = 100
        [Test]
        public void Test3()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 100M);
        }

        // A - 5 B - 5 C- 1 D- 0 = 370
        [Test]
        public void Test4()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "5"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "5"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 370M);
        }

        // A - 3 B - 5 C- 1 D- 1 = 280
        [Test]
        public void Test5()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "3"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "5"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 280M);
        }

        // A - 1 B - 1 C- 1 D- 1 = 110
        [Test]
        public void Test6()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 110M);
        }

        // A - 0 B - 3 C- 2 D- 3 = 150
        [Test]
        public void Test7()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "3"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "2"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "3"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 150M);
        }

        // A - 0 B - 3 C- 0 D- 3 = 120
        [Test]
        public void Test8()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "3"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "3"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 120M);
        }


        // A - 3 B - 3 C- 0 D- 3 = 250
        [Test]
        public void Test9()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "3"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "3"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "3"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 250M);
        }

        // A - 0 B - 0 C- 0 D- 0 = 0
        [Test]
        public void Test10()
        {
            List<Product> list = new List<Product>();

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 0M);
        }

        // A - 1 B - 7 C- 0 D- 0 = 215
        [Test]
        public void Test11()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "7"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 215M);
        }

        // A - 0 B - 0 C- 0 D- 2 = 30
        [Test]
        public void Test12()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "2"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 30M);
        }

        // A - 30 B - 0 C- 0 D- 0 = 1300
        [Test]
        public void Test13()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.A, "30"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 1300M);
        }

        // A - 0 B - 20 C- 2 D- 1 = 500
        [Test]
        public void Test14()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.B, "20"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "2"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "1"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 500M);
        }

        // A - 0 B - 0 C- 1 D- 5 = 90
        [Test]
        public void Test15()
        {
            List<Product> list = new List<Product>();
            list.AddRange(Product.getNumOfProducts(ProductEnum.C, "1"));
            list.AddRange(Product.getNumOfProducts(ProductEnum.D, "5"));

            PromotionService productService = new PromotionService();
            decimal totalVal = productService.getTotalValue(list);
            Assert.AreEqual(totalVal, 90M);
        }
    }
}
