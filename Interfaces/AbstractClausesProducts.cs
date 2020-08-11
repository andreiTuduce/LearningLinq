using System.Collections.Generic;
using Try101LinqSamples;

namespace ConsoleApp_Linq.Interfaces
{
    public abstract class AbstractClausesProducts
    {
        public virtual void LinqSyntax(List<Product> products) { }

        public virtual void SqlSyntax(List<Product> products) { }

        public virtual void CodeSyntax(List<Product> products) { }
    }
}
