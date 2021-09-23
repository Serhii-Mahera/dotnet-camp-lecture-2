using System;

namespace Camp.CSharp.MethodsOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple methods
            SimpleMethod();
            var result = SimpleMethodWithReturn();
            Print("Serhii", lastName: "Mahera");

            // Invoking methods using named parameters​
            Print(name: "Serhii", lastName: "Mahera", age: 22);

            // Methods overloading
            Add(1, 1);
            Add(1.0, 1.0);
            Add(1m, 2m);

            // Local functions problem
            LocalFunctionsProblem(true);

            // Local function peoblem solving
            LocalFunctionsSolution(true);

            // Extension method call
            var extensionMethods = "Extension method calls:";
            extensionMethods.Print();
            result.ToString().Print();
            "Bye".Print();
        }

        public static void SimpleMethod()
        {
            Console.WriteLine("Simple Method");
        }

        public static int SimpleMethodWithReturn()
        {
            Console.WriteLine("Simple Method with return");
            return 25;
        }

        public static int Print(string name, int? age = null, string lastName = null)
        {
            Console.WriteLine("Print");
            if(!string.IsNullOrWhiteSpace(lastName))
            {
                Console.Write($"Your lastname: {lastName}; ");
            }

            if(!string.IsNullOrWhiteSpace(name))
            {
                Console.Write($"Your name: {name}; ");
            }

            if(age.HasValue)
            {
                Console.Write($"You are {age} years old; ");
            }

            Console.WriteLine();

            return 0;
        }

        public static int Add(int a, int b) => a + b;
        public static double Add(double a, double b) => a + b;
        public static decimal Add(decimal a, decimal b) => a + b;
        public static decimal Add(decimal a, decimal b, decimal c) => a + b + c;

        public static void LocalFunctionsProblem(bool printResults)
        {
            Console.WriteLine("***** Local Functions Problem *****");
            var result = 10 / 5;
            if(printResults)
            {
                Console.WriteLine($"Your result is {result}");
            }

            var result1 = 100 / 10;
            if(printResults)
            {
                Console.WriteLine($"Your result is {result1}");
            }

            var result2 = 50 / 10;
            if(printResults)
            {
                Console.WriteLine($"Your result is {result2}");
            }
        }
        public static void LocalFunctionsSolution(bool printResults)
        {
            Console.WriteLine("***** Local Functions Solution *****");
            DivideAndPrint(10, 5, printResults);
            DivideAndPrint(100, 10, printResults);
            DivideAndPrint(50, 10, printResults);

            void DivideAndPrint(int value, int divideBy, bool printOutput = true)
            {
                var result = value / divideBy;
                if(printOutput)
                {
                    Console.WriteLine($"Your result is {result}");
                }
            }
        }
    }
}
