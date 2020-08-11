using System.Collections.Generic;
using System.Linq;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class Grouping : AbstractClausesCustomer
    {
        public override void CodeSyntax(List<Customer> customers)
        {
            Dictionary<string, int> groupedCustomers = new Dictionary<string, int>();

            customers.ForEach(customer => {
                if (groupedCustomers.ContainsKey(customer.Country))
                    groupedCustomers[customer.Country]++;
                else
                    groupedCustomers.Add(customer.Country, 1);
                    
            });

            groupedCustomers.DisplayValues();
        }

        public override void LinqSyntax(List<Customer> customers)
        {
            var groupedCustomers = customers.GroupBy(customer => customer.Country).Select(v => v.Key).ToList();

            groupedCustomers.DisplayValues();
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            var groupedCustomers = from c in customers
                                   group c by c.Country into country
                                   orderby country.Key
                                   select country;

            groupedCustomers.DisplayValues();
        }
    }
}
