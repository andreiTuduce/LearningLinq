using ConsoleApp_Linq.Helpers;
using System.Collections.Generic;
using System.Linq;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class Select : IClausesCustomer
    {
        public override void CodeSyntax(List<Customer> customers)
        {
            TextHelper.ShowCodeText();

            List<string> names = new List<string>();

            foreach (Customer customer in customers)
            {
                foreach (Order order in customer.Orders)
                {
                    if (order.OrderID % 2 == 0)
                        names.Add(order.ToString());
                }
            }

            names.DisplayValues();
        }

        public override void LinqSyntax(List<Customer> customers)
        {
            TextHelper.ShowLinqText();

            List<string> names = customers.SelectMany(customer => customer.Orders).Where(order => order.OrderID % 2 == 0).Select(order => order.ToString()).ToList();

            names.DisplayValues();
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            TextHelper.ShowSqlText();

            IEnumerable<string> names = from c in customers
                                        from o in c.Orders
                                        where o.OrderID % 2 == 0
                                        select o.ToString();

            names.DisplayValues();
        }
    }
}
