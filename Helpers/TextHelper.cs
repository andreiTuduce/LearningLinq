using System;

namespace ConsoleApp_Linq.Helpers
{
    public static class TextHelper
    {
        public static void ShowLinqText() => Console.WriteLine("Linq syntax!");

        public static void ShowSqlText() => Console.WriteLine("Sql syntax!");

        public static void ShowCodeText() => Console.WriteLine("Code syntax!");

        public static void ShowTimePassed(TimeSpan time) => Console.WriteLine($"Performance time {time} \n");
    }
}
