using System;
using System.Collections.Generic;
using System.Reflection;

namespace Camp.CSharp.Events
{
    class Program
    {

        //Anonymous methods
        public static void Main(string[] args)
        {
            var car = new Car();

            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now, use an anonymous method
            List<int> evenNumbers = list.FindAll(delegate (int i)
                {
                    return (i % 2) == 0;
                });
            Console.WriteLine("Here are your even numbers:");
            foreach(int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        // Use of Predicate delegate
        //public static void Main(string[] args)
        //{
        //    // Make a list of integers.
        //    List<int> list = new List<int>();
        //    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

        //    // Call FindAll() using traditional delegate syntax.
        //    Predicate<int> callback = IsEvenNumber;
        //    List<int> evenNumbers = list.FindAll(callback);
        //    Console.WriteLine("Here are your even numbers:");
        //    foreach(int evenNumber in evenNumbers)
        //    {
        //        Console.Write("{0}\t", evenNumber);
        //    }

        //    Console.WriteLine();
        //}

        // Target for the Predicate<> delegate.
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }
    }

    public class Car
    {
        public event EventHandler<CarEventArgs> Exploaded;
        public void Accelerate()
        {
            // Event will have null value if there are no subscribers
            // We should use null-check in order to omit exception
            Exploaded?.Invoke(this, new CarEventArgs("Overwhelmed", 120));
        }

    }

    // Custom event args
    public class CarEventArgs : EventArgs
    {
        public string Message { get; }
        public int Speed { get; }

        public CarEventArgs(string message, int speed)
        {
            Message = message;
            Speed = speed;
        }
    }
}
