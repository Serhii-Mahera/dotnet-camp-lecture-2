using System;
using System.Text;

namespace Camp.CSharp.WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOverview();
            StringBuilderOverview();
            Console.WriteLine("Bye!");
        }

        public static void StringOverview()
        {
            Console.WriteLine("***** String *****");
            string hello = "Hello ";
            string world = "World";
            
            // new string
            string helloWorld = hello + world; 
            string predefinedHelloWorld = "Hello World!";

            var upperString = helloWorld.ToUpper();
            Console.WriteLine($"helloWorld = {helloWorld}; upperString = {upperString};");

            // Strings are immutable
            // This will create new string
            helloWorld = helloWorld + "!"; 

            // Equals is overrided for string comparison
            // to compare value of string, not references as other reference types
            Console.WriteLine(helloWorld == predefinedHelloWorld);
        }

        public static void StringBuilderOverview()
        {
            Console.WriteLine("***** String Builder *****");
            // It is better to use string builder
            // when you need to manipulate string a lot
            var stringBuilder = new StringBuilder();
            Console.WriteLine($"Capacity: {stringBuilder.Capacity}; Length: {stringBuilder.Length}");
            for(int i = 0; i < 100; i++)
            {
                stringBuilder.Append($"The number is {i}");
                stringBuilder.AppendLine();

                Console.WriteLine($"Capacity: {stringBuilder.Capacity}; Length: {stringBuilder.Length}");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
