using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    // Class Customer for creating a person(customer)
    public class Customer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public Customer(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
