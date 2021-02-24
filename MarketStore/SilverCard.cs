using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class SilverCard : Card
    {
        public SilverCard(Customer customer, double turnover) : base(customer,turnover,0.02f) { }
        public override double getDiscountRate()
        {
            if (turnover > 300)
                initialDiscountRate = 0.035f;
            
            return initialDiscountRate;
        }
    }
}
