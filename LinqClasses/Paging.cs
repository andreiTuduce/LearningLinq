using ConsoleApp_Linq.Helpers;
using System.Collections.Generic;
using System.Linq;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class Paging : IClausesCustomer
    {
        public int SkipCount { get; set; }

        private readonly List<string> RetrievedCustomers = new List<string>();

        public override void CodeSyntax(List<Customer> customers)
        {
            TextHelper.ShowCodeText();

            int currentNumber = RetrievedCustomers.Count != 0 ? RetrievedCustomers.Count() - 1 : 0;

            if (currentNumber > customers.Count)
                currentNumber = customers.Count - 1;

            if (SkipCount > customers.Count)
                SkipCount = customers.Count;

            for (int i = currentNumber; i < SkipCount; i++)
            {
                RetrievedCustomers.Add(customers[i].ToString());
            }

            RetrievedCustomers.DisplayValues();
        }

        public override void LinqSyntax(List<Customer> customers)
        {
            TextHelper.ShowLinqText();

            int currentNumber = RetrievedCustomers != null ? RetrievedCustomers.Count() - 1 : 0;

            RetrievedCustomers.AddRange(customers.Skip(currentNumber + SkipCount).Take(SkipCount).Select(customer => customer.ToString()).ToList());

            RetrievedCustomers.DisplayValues();
        }

        public override void SqlSyntax(List<Customer> customers)
        {
            TextHelper.ShowSqlText();
            //How to do the paging here? 
        }
    }
}
