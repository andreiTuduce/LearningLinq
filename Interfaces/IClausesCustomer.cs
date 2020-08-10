using System.Collections.Generic;
using Try101LinqSamples;

namespace ConsoleApp_Linq.LinqClasses
{
    public abstract class IClausesCustomer
    {
        public virtual void LinqSyntax(List<Customer> customers) { }

        public virtual void SqlSyntax(List<Customer> customers) { }

        public virtual void CodeSyntax(List<Customer> customers) { }

    }
}
