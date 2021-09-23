using System;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("=> Data type Functionality:");
Console.WriteLine("Max of int: {0}", int.MaxValue); // 2147483647
Console.WriteLine("Min of int: {0}", int.MinValue); // -2147483648

Console.WriteLine("Max of double: {0}", double.MaxValue); // 1.7976931348623157E+308
Console.WriteLine("Min of double: {0}", double.MinValue); //-1.7976931348623157E+308
Console.WriteLine("double.Epsilon: {0}", double.Epsilon); // 5E-324
Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity); // ∞
Console.WriteLine("double.NegativeInfinity: {0}",double.NegativeInfinity); // -∞
Console.WriteLine("double.NaN: {0}", double.NaN); // NaN
Console.WriteLine();

Console.WriteLine("bool.FalseString: {0}", bool.FalseString); // False
Console.WriteLine("bool.TrueString: {0}", bool.TrueString); // True

Console.WriteLine("=> char type Functionality:");
char myChar = 'a';
Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar)); // False
Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar)); // True
Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5)); // True
Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6)); // False
Console.WriteLine("char.IsPunctuation('?'): {0}",char.IsPunctuation('?')); // True
Console.WriteLine();
