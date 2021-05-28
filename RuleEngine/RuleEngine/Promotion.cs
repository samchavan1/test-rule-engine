using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    public class Promotion
    {
        public int Id { get; set; }

        public Dictionary<ProductEnum, int> PromoInfo { get; set; }

        public decimal Price { get; set; }

    }

    public class PromotionList
    {
        public static List<Promotion> getPromotionList()
        {
            List<Promotion> List = new List<Promotion>();

            Promotion promotion1 = new Promotion();
            promotion1.Id = 1;
            promotion1.PromoInfo = new Dictionary<ProductEnum, int>();
            promotion1.PromoInfo.Add(ProductEnum.A, 3);
            promotion1.Price = 130M;

            Promotion promotion2 = new Promotion();
            promotion2.Id = 2;
            promotion2.PromoInfo = new Dictionary<ProductEnum, int>();
            promotion2.PromoInfo.Add(ProductEnum.B, 2);
            promotion2.Price = 45M;

            Promotion promotion3 = new Promotion();
            promotion3.Id = 3;
            promotion3.PromoInfo = new Dictionary<ProductEnum, int>();
            promotion3.PromoInfo.Add(ProductEnum.C, 1);
            promotion3.PromoInfo.Add(ProductEnum.D, 1);
            promotion3.Price = 30M;

            List.Add(promotion1);
            List.Add(promotion2);
            List.Add(promotion3);

            return List;
        }


    }
}
