using ConsoleApp_Linq.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ConsoleApp_Linq
{
    public static class ExtensionMethods
    {
        private static readonly Stopwatch stopwatch = new Stopwatch();

        public static void PerformanceTesting(this Action action)
        {
            stopwatch.Start();
            action.Invoke();
            stopwatch.Stop();
            TextHelper.ShowTimePassed(stopwatch.Elapsed);
        }

        public static void DisplayValues<T>(this IEnumerable<T> values)
        {
            foreach (T value in values)
            {
                Console.WriteLine(value);
            }
        }

        public static void DisplayValuesByProp<T>(this IEnumerable<T> values, string property)
        {
            foreach (T value in values)
            {
                value.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(value)).TryGetValue(property, out object propValue);

                Console.WriteLine(propValue);
            }
        }
    }
}
