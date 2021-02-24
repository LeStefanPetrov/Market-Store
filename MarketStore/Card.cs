using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    // Abstract class Card with an abstract method getDiscountRate which calculates the discount rate based on the turnover
    public abstract class Card
    {
        protected Customer customer { get; set; }
        protected double turnover { get; set; }
        protected double initialDiscountRate { get; set; }

        public Card(Customer customer, double turnover, double initialDiscountRate)
        {
            this.customer = customer;
            this.turnover = turnover;
            this.initialDiscountRate = initialDiscountRate;
        }

        public abstract double getDiscountRate();
    }
}
