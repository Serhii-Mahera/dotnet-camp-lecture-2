using System;

Console.WriteLine("Checked and unchecked context");

// Can you predict the result?
byte number1 = 160;
byte number2 = 160;
byte result = (byte)(number1 + number2);
Console.WriteLine($"{number1} + {number2} = {result}");

// Given that a System.Byte can hold a value 
// only between 0 and 255 (inclusive, for a grand total of 256 slots), sum now contains the overflow value 
// (320 - 256 = 64).
// C# program is in unchecked context by defaut.

// To handle overflow or underflow conditions in your application
// you should wrap a statement (or a block of statements) 
// within the scope of the `checked` keyword, the C# compiler emits additional CIL instructions that test for 
// overflow conditions that may result when adding, multiplying, subtracting, or dividing two numerical data 
// types.
// This time, tell the compiler to add CIL code
// to throw an exception if overflow/underflow
// takes place.
try
{
    result = checked((byte)(number1 + number2));
    Console.WriteLine($"{number1} + {number2} = {result}");
}
catch(OverflowException ex)
{
    Console.WriteLine(ex.Message);
}

// If you want to force overflow checking to occur over a block of code statements,
// you can do so by defining a “checked scope” as follows:
try
{
    checked
    {
        result = (byte)(number1 + number2);
        Console.WriteLine($"{number1} + {number2} = {result}");
    }
}
catch(OverflowException ex)
{
    Console.WriteLine(ex.Message);
}

//
// You could force compiler to use global checked context
// 1. C# compiler supports the /checked flag.
// 2. From Properties -> Build -> Advanced by setting "Check for arithmetic overflow/underflow" check box (for debug purposes)

// Now, assuming you have enabled this project-wide setting, what are you to do if you have a block of code 
// where data loss is acceptable? Given that the /checked flag will evaluate all arithmetic logic, C# provides 
// the unchecked keyword to disable the throwing of an overflow exception on a case-by-case basis. This 
// keyword’s use is identical to that of the checked keyword in that you can specify a single statement or a block 
// of statements.
unchecked
{
    result = (byte)(number1 + number2);
    Console.WriteLine($"{number1} + {number2} = {result}");
}