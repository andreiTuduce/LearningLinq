using ConsoleApp_Linq.Helpers;
using ConsoleApp_Linq.LinqClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Try101LinqSamples;

namespace ConsoleApp_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = Customers.CustomerList;

            #region AllClause

            //AllClause allClause = new AllClause();
            //AllClauseMethods(customers, allClause);

            #endregion

            #region Paging

            //Paging paging = new Paging
            //{
            //    SkipCount = 10
            //};

            //PagingMethods(customers, paging);
            #endregion

            #region Select

            //Select select = new Select();
            //SelectSyntax(customers, select);

            #endregion

            #region Ordering

            Ordering ordering = new Ordering();

            ordering.CodeSyntax(customers);

            #endregion

            Grouping grouping = new Grouping();
            grouping.LinqSyntax(customers);

            Console.ReadKey();
            /*
             Any, Average, Cast, Distinct, GroupBy, Join,
            Max, Min, SkipWhile, Sum, Take-While, 
            */
        }

        private static void SelectSyntax(List<Customer> customers, Select select)
        {
            Action a = () => select.CodeSyntax(customers);
            a.PerformanceTesting();
            Action b = () => select.LinqSyntax(customers);
            b.PerformanceTesting();
            Action c = () => select.SqlSyntax(customers);
            c.PerformanceTesting();
        }

        private static void PagingMethods(List<Customer> customers, Paging paging)
        {
            Action linqSyntaxAction = () => paging.LinqSyntax(customers);
            Action codeSyntaxAction = () => paging.CodeSyntax(customers);
            linqSyntaxAction.PerformanceTesting();
            codeSyntaxAction.PerformanceTesting();

            paging.SkipCount = 20;

            linqSyntaxAction.PerformanceTesting();
            codeSyntaxAction.PerformanceTesting();
        }

        private static void AllClauseMethods(List<Customer> customers, AllClause allClause)
        {
            Action a = () => allClause.LinqSyntax(customers);
            a.PerformanceTesting();
            allClause.SqlSyntax(customers);
            allClause.CodeSyntax(customers);
        }

    }
}
