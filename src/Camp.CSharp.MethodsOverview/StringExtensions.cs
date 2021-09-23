using System;

namespace Camp.CSharp.MethodsOverview
{
    public static class StringExtensions
    {
        // This is extension method
        public static void Print(this string value)
        {
            Console.WriteLine(value);
        }
    }
}
