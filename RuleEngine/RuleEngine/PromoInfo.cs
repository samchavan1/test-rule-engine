using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    public class PromoInfo
    {
        public int promoCount { get; set; }
        public int prodCount { get; set; }

        public PromoInfo(int _promoCount, int _prodCount)
        {
            this.promoCount = _promoCount;
            this.prodCount = _prodCount;
        }
    }
}
