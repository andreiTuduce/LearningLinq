using ConsoleApp_Linq.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class Ordering : AbstractClausesCustomer
    {
        public override void CodeSyntax(List<Customer> customers)
        {
            bool changed = true;

            while (changed)
            {
                changed = false;

                for (int i = 0; i < customers.Count() - 1; i++)
                {
                    if (string.CompareOrdinal(customers[i].Address, customers[i + 1].Address) > 0)
                    {
                        Customer aux = customers[i];
                        customers[i] = customers[i + 1];
                        customers[i + 1] = aux;
                        changed = true;
                    }
                }
            }

            customers.DisplayValuesByProp(Identifiers.Address);
        }

        public override void LinqSyntax(List<Customer> customers)
        {
            List<Customer> orderdCustomers = customers.Select(customer => customer).OrderBy(customer => customer.Address).ToList();

            customers.DisplayValuesByProp(Identifiers.Address);
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            var result = from c in customers
                         orderby c.Address
                         select new
                         {
                             c
                         };

            customers.DisplayValuesByProp(Identifiers.Address);
        }

        public void OrderByDescendingThenBy(List<Customer> customers)
        {
            List<Customer> orderdCustomers = customers.Select(customer => customer).OrderByDescending(customer => customer.Address).ThenBy(customer=> customer.City).ToList();

            customers.DisplayValuesByProp(Identifiers.City);
        }


        public void OrderByDescendingThenBySql(List<Customer> customers)
        {
            var result = from c in customers
                         orderby c.Address descending
                         orderby c.City
                         select new
                         {
                             c
                         };

            customers.DisplayValuesByProp(Identifiers.City);
        }
    }
}
