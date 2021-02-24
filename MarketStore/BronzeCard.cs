using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class BronzeCard : Card
    {
        public BronzeCard(Customer customer, double turnover) : base(customer,turnover,0.0f) { }
        public override double getDiscountRate() 
        {
            if (turnover < 100)
                initialDiscountRate = 0.0f;
            else if (turnover > 100 && turnover < 300)
                initialDiscountRate = 0.01f;
            else
                initialDiscountRate = 0.025f;

            return initialDiscountRate;
        }
    }
}
