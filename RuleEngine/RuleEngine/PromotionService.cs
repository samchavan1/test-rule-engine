using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleEngine
{
    public class PromotionService
    {
        public decimal getTotalValue(List<Product> products)
        {
            List<Promotion> list = PromotionList.getPromotionList();

            Dictionary<ProductEnum, int> prodInfo = products.GroupBy(x => x.Id).ToDictionary(g => g.Key, g => g.ToList().Count());

            decimal promoPrice = 0M;
            List<ProductEnum> priceCalculated = new List<ProductEnum>();

            foreach (Promotion promotion in list)
            {
                Dictionary<Product, PromoInfo> promoApplied = new Dictionary<Product, PromoInfo>();

                foreach (var item in promotion.PromoInfo)
                {
                    if (products.Any(p => p.Id == item.Key))
                    {
                        promoApplied.Add(products.FirstOrDefault(p => p.Id == item.Key), applyPromotion(products, item.Key, item.Value));
                    }
                }

                if (promoApplied.Values.Count > 0 && promoApplied.Values.Count == promotion.PromoInfo.Count)
                {
                    int minValue = promoApplied.Values.Min(p => p.promoCount);

                    foreach (var item in promoApplied)
                    {
                        priceCalculated.Add(item.Key.Id);
                        promoPrice += (item.Key.Price * (prodInfo[item.Key.Id] - (item.Value.prodCount * minValue)));
                    }

                    promoPrice += minValue * promotion.Price;
                }
            }

            foreach (var item in prodInfo)
            {
                if(priceCalculated.Any(p=> p == item.Key))
                {
                    continue;
                }

                promoPrice += products.FirstOrDefault(p => p.Id == item.Key).Price * item.Value;
            }
           
            return promoPrice;
        }

        public PromoInfo applyPromotion(List<Product> lst, ProductEnum product, int count)
        {
            List<Product> newProd = lst.Where(p => p.Id == product).ToList();

            int promoCount = newProd.Count() / count;
            return new PromoInfo(promoCount, count);
        }
    }
}
