using ConsoleApp_Linq.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public class SkipWhile : AbstractClausesProducts
    {
        public override void CodeSyntax(List<Product> products)
        {
            List<Product> result = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].UnitsInStock <= 25)
                    result.Add(products[i]);
            }

            result.DisplayValues();

        }

        public override void LinqSyntax(List<Product> products)
        {
            List<Product> result = products.OrderByDescending(product => product.UnitsInStock).SkipWhile(product => product.UnitsInStock >= 25).ToList();

            result.DisplayValues();
        }

        public override void SqlSyntax(List<Product> products)
        {

        }
    }
}
