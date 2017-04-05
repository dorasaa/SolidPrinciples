using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();
            customers.Add(new GoldCustomer(new EmailLogger()));
            customers.Add(new SilverCustomer(new EmailLogger()));
            //customers.Add(new enquiry());   
            foreach (var customer in customers)
            {
                customer.Add();
            }
        }
    }
}
