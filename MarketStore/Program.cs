using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var FirstOwner = new Customer("Stefan", "Petrov");
                var SecondOwner = new Customer("Ivan", "Ivanov");
                var ThirdOwner = new Customer("Simeon", "Georgiev");

                var BronzeCard = new BronzeCard(FirstOwner, 0);
                var SilverCard = new SilverCard(SecondOwner, 600);
                var GoldCard = new GoldCard(ThirdOwner, 1500);

                var PurchaseOne = new Purchase("HDD", 150);
                var PurchaseTwo = new Purchase("Huawei", 850);
                var PurchaseThree = new Purchase("Lenovo Y530", 1300);

                Purchase.PrintInfo(BronzeCard, PurchaseOne);
                Purchase.PrintInfo(SilverCard, PurchaseTwo);
                Purchase.PrintInfo(GoldCard, PurchaseThree);

                Console.ReadKey();

            } catch(Exception e)
            {
                Console.WriteLine("Error:{0}",e.Message);
            }
        }
    }
}
