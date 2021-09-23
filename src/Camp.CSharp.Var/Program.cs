using System;
class Program
{
    static void Main()
    {
        // Equals to `int integer = 0;`
        var integer = 0;
        // Equals to `decimal @decimal = 0;`
        var @decimal = 0M;
        // Equals to `float @float = 0;`
        var @float = 0F;
        // Equals to `bool @bool = true;`
        var @bool = true;
        // Equals to `string @string = "My custom string";`
        var @string = "My custom string";
        // Equals to `double @double = 0d
        var @double = 0d;
        // Equals to `int[] @array = new int[0];`
        var @array = new int[0];

        Console.ReadLine();
    }

    // You can't use `var` outside of method scope
    // public var someNumber = 125;
}