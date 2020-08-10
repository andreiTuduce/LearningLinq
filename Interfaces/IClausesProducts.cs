using System.Collections.Generic;
using Try101LinqSamples;

namespace ConsoleApp_Linq.Interfaces
{
    public abstract class IClausesProducts
    {
        public virtual void Linq(List<Product> customers) { }

        public virtual void SqlSyntax(List<Product> customers) { }

        public virtual void CodeSyntax(List<Product> customers) { }
    }
}
