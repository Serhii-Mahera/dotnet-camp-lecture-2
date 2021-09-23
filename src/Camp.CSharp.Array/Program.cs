using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;

namespace Camp.CSharp.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitTypeArrays();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();

            Console.WriteLine("Bye!");
        }

        // be aware that if you declare an array but do not explicitly fill each index, each item will be set to the 
        // default value of the data type(e.g., an array of bools will be set to false or an array of ints will be set to 0).
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            // Create a 100 item string array, indexed 0 - 99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        // In addition to filling an array element by element,
        // you are able to fill the items of an array using C# array 
        // initialization syntax.To do so, specify each array item
        // within the scope of curly brackets ({ }). 
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");
            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[]
            { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            // OOPS! Mismatch of size and elements!
            //int[] intArray = new int[2] { 20, 22, 23, 0 };

            Console.WriteLine();
        }

        // Recall that the var keyword allows you to define a variable,
        // whose underlying type is determined by the compiler.
        // In a similar vein, the var keyword can be used to define implicitly typed local arrays.
        static void DeclareImplicitTypeArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());

            // Error! Mixed types!
            // var d = new[] { 1, "one", 2, "two", false }

            Console.WriteLine();
        }

        // a rectangular array is simply an array of multiple dimensions,
        // where each row is of the same length
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // Populate (3 * 4) array.
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;
            // Print (3 * 4) array.
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //  jagged arrays contain some number of inner arrays,
        //  each of which may have a different upper limit.
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];
            // Create the jagged array.
            for(int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            // Print each row (remember, each element is defaulted to zero!).
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}