using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class GoldCard : Card
    {
        public GoldCard(Customer customer, double turnover) : base(customer,turnover,0.02f) { }
        public override double getDiscountRate()
        {
            double tempTurnover = turnover;
            while (tempTurnover > 100)
            {
                if (initialDiscountRate >= 0.099f) break; // binary double - 0.10 is 0.099999 . If we use >=10 we get 11% discount rate hence wrong output
                initialDiscountRate += 0.01f;
                tempTurnover -= 100;
            }

            return initialDiscountRate;
        }
    }
}
