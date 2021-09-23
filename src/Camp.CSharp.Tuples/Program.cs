using System;

namespace Camp.CSharp.Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Tuple *****");

            (string, int, Wallet) empty = (string.Empty, 0, new Wallet(0.0M, 0.0M));
            Console.WriteLine($"Item1: {empty.Item1}\nItem2: {empty.Item2}\nItem3: Dollars: {empty.Item3.Dollars} Euro's: {empty.Item3.Euros}\n");
            
            // When setting the names on the right, you must use the keyword var
            // In other case only ItemX will be aceesible
            // !!! Uncomment below sample, you can't acess Name or other field name
            //(string, int, Wallet) rightPart = (Name: string.Empty, Age: 0, Wallet: new Wallet(0.0M, 0.0M));
            var rightPart = (Name: "John", Age: 1, Wallet: new Wallet(10.0M, 5.0M));
            Console.WriteLine($"Item1: {rightPart.Item1}\nItem2: {rightPart.Item2}\nItem3: Dollars: {rightPart.Item3.Dollars} Euro's: {rightPart.Item3.Euros}\n");

            // Create the tupple with 3 fields
            (string Name, int Age, Wallet Wallet) leftPart = ("Ivan", 12, new Wallet(12.0M, 1.0M));
            // ItemX points to the same object as field name 
            Console.WriteLine($"leftPart.Item3 == leftPart.Wallet? {leftPart.Item3 == leftPart.Wallet}\n");

            Console.WriteLine();
            var person = ReturnTuple();
            Console.WriteLine($"Getting person info:\nAge: {person.Age}\nMiddle Name: {person.MiddleName}\nLast Name: {person.LastName}\n");

            TupleAsInput(person);

            // Deconstructing is the term given when separating out the properties of a tuple to be used individually. 
            // If you need to skip some parameters,
            // you could use discar d _ symbol
            (int age, string _, string lastName) = ReturnTuple();
            Console.WriteLine($"Deconstructing:\nAge:{age}\nLastName: {lastName}");
        }
        // You could use tuples to return multiple values from method
        public static (int Age, string MiddleName, string LastName) ReturnTuple() => (25, "Ivanovych", "Ivanov");
        public static void TupleAsInput((int Age, string MiddleName, string LastName) person)
        {
            Console.WriteLine($"Tuple passed to the method:\nAge: {person.Age}\nMiddle Name: {person.MiddleName}\nLast Name: {person.LastName}\n");
        }


        public class Wallet
        {
            public decimal Euros { get; }
            public decimal Dollars { get; }

            public Wallet(decimal dollars, decimal euros)
            {
                this.Dollars = dollars;
                this.Euros = euros;
            }

            // This method can be named anything, but by convention it is typically named Deconstruct().
            // This allows a single method call to get the individual values of the structure by returning a tuple
            public (decimal Euros, decimal Dollars) Deconstruct() => (Euros, Dollars);
        }
    }
}
