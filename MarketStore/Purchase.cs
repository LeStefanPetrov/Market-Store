using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    // Class Purchase for the purchased item and method PrintInfo that prints all the neccesary info about the purchase
    class Purchase
    { 
        public string PurchaseName { get; set; }
        public double PurchaseValue { get; set; }

        public Purchase(string name, double value)
        {
            this.PurchaseName = name;
            this.PurchaseValue = value;
        }

        public static void PrintInfo(Card card, Purchase purchase)
        {
            Console.WriteLine("Purchase Value: {0}", purchase.PurchaseValue.ToString("C2"));
            Console.WriteLine("Discount Rate: {0}%", (card.getDiscountRate() * 100).ToString("F1"));
            Console.WriteLine("Discount: {0}", (card.getDiscountRate() * purchase.PurchaseValue).ToString("C2"));
            Console.WriteLine("Total: {0}", (purchase.PurchaseValue - (card.getDiscountRate() * purchase.PurchaseValue)).ToString("C2"));
            Console.WriteLine();
        }
    }
}
