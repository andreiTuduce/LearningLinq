using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class Grouping : IClausesCustomer
    {
        public override void CodeSyntax(List<Customer> customers)
        {
            base.CodeSyntax(customers);
        }

        public override void LinqSyntax(List<Customer> customers)
        {
            var orderdCustomers = customers.GroupBy(customer => customer.Country).Select(v => v.Key).ToList();

            orderdCustomers.DisplayValues();
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            base.SqlSyntax(customers);
        }
    }
}
