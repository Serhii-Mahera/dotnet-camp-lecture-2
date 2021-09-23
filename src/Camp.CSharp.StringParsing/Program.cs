using System;

Console.WriteLine("=> Data type parsing:");
bool b = bool.Parse("True");
Console.WriteLine("Value of b: {0}", b);
double d = double.Parse("99.884");
Console.WriteLine("Value of d: {0}", d);
int i = int.Parse("8");
Console.WriteLine("Value of i: {0}", i);
char c = Char.Parse("w");
Console.WriteLine("Value of c: {0}", c);
Console.WriteLine();

Console.WriteLine("=> Data type parsing with TryParse:");
if(bool.TryParse("True", out bool parsedB))
{
    Console.WriteLine("Value of b: {0}", parsedB);
}
string value = "Hello";
if(double.TryParse(value, out double parsedValue))
{
    Console.WriteLine("Value of d: {0}", parsedValue);
}
else
{
    Console.WriteLine("Failed to convert the input ({0}) to a double", value);
}
Console.WriteLine();
