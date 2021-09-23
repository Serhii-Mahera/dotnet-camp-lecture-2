using System;
using System.IO;

namespace Camp.CSharp.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make a Colors variable.
            Colors color = Colors.Green;
            ShowTheColor(color);
            // Because enumerations are a fixed set of name-value pairs, it is illegal to set an 
            // enum variable to a value that is not defined directly by the enumerated type.
            // Colors color2 = Colors.DarkGreen;
            
            UseOfSystemEnumType();

            Console.ReadLine();
        }
        public static void UseOfSystemEnumType()
        {
            Console.WriteLine("***** System.Enum *****");
            // Get all names that exists in Colors enum
            var names = Enum.GetNames(typeof(Colors));
            Console.WriteLine("Enum names: ");
            foreach(string name in names)
            {
                Console.WriteLine($"{name}, ");
            }

            if(Enum.TryParse<Colors>("RED", true, out Colors red))
            {
                Console.WriteLine($"Successfully parsed color: {red}");
            }

            var values = Enum.GetValues<Colors>();
            Console.WriteLine("Enum values: ");
            foreach(Colors value in values)
            {
                Console.WriteLine($"{value} = {(byte)value}");
            }

            Colors notKnown = (Colors)13;
            if(!Enum.IsDefined<Colors>(notKnown))
            {
                Console.WriteLine($"Color with value `{notKnown}` is not defined");
            }
        }
        public static void ShowTheColor(Colors color)
        {
            switch(color)
            {
                case Colors.Red:
                    Console.WriteLine("Your color is RED");
                    break;
                case Colors.Green:
                    Console.WriteLine("Your color is Green");
                    break;
                case Colors.Blue:
                    Console.WriteLine("Your color is Blue");
                    break;
                case Colors.Orange:
                    Console.WriteLine("Your color is Orange");
                    break;
                case Colors.Yellow:
                    Console.WriteLine("Your color is Yellow");
                    break;
                case Colors.Black:
                    Console.WriteLine("Your color is Black");
                    break;
                case Colors.Violet:
                    Console.WriteLine("Your color is Violet");
                    break;
                case Colors.Brown:
                    Console.WriteLine("Your color is Brown");
                    break;
                default:
                    Console.WriteLine("We do not know such color");
                    break;
            }
        }
    }


    // You could change underlying type 
    // for storing enum value
    public enum Colors : byte
    {
        Red,    // 0
        Green,  // 1
        Blue,   // 2
        Orange, // 3
        Yellow, // 4
        Black,   // 5
        // You can assign any number
        // that fits into type border
        // !!! 256 Compile-time error !!! 
        // 256 is too big for a byte!
        Violet = 255,
        // Enumerations do not necessarily need
        // to follow a sequential ordering.
        Brown = 125,
    }
}
