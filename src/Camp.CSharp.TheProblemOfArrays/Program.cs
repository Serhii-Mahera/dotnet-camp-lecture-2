using System;

namespace Camp.CSharp.TheProblemOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array of string data.
            string[] strArray = { "First", "Second", "Third" };
           
            // Show number of items in array using Length property.
            Console.WriteLine("This array has {0} items.", strArray.Length);
            Console.WriteLine();

            // Display contents using enumerator.
            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }

            Console.WriteLine();
            
            // Reverse the array and print again.
            Array.Reverse(strArray);
            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }

            // Try to add a new item at the end?? Runtime error!
            strArray[3] = "new item?";

            Console.ReadLine();
        }
    }
}
