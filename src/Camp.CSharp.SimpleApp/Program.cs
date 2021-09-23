// C# 9.0
//using System;

//Console.WriteLine("Hello World!");
//Console.WriteLine(args.Length);

//Before C# 9.0
using System;

namespace Camp.CSharp.SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// sync Main
//static void Main()
//static int Main()
//static void Main(string[])
//static int Main(string[])

// Async Main (C# 7.1)
//static Task Main()
//static Task<int> Main()
//static Task Main(string[])
//static Task<int> Main(string[])