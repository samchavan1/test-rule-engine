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
           
            return promoPrice;
        }
    }
}
