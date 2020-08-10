using ConsoleApp_Linq.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class AllClause : IClausesCustomer
    {
        public override void LinqSyntax(List<Customer> customers)
        {
            TextHelper.ShowLinqText();
            Console.WriteLine(customers.All(customer => customer.Orders.Length > 15));
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            TextHelper.ShowSqlText();

            var result = from customer in customers
                         where customer.Orders.Length > 15
                         select new
                         {
                             c = customer
                         };


            Console.WriteLine(result.Count() == customers.Count());
        }

        public override void CodeSyntax(List<Customer> customers)
        {
            TextHelper.ShowCodeText();

            int customersCount = 0;

            foreach (Customer customer in customers)
            {
                if (customer.Orders.Length > 15)
                {
                    customersCount++;
                }
            }

            Console.WriteLine(customers.Count() == customersCount);
        }

    }
}
