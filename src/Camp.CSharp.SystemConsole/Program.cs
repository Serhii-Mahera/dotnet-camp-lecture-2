using System;

// Set the title of console app
Console.Title = "C# System.Console class";

// Only supported on windows
// Set window size to heigth of 25 rows and width of 100 columns
Console.SetWindowSize(100, 25);

// Mustn't be less than current console size
//Console.BufferWidth= 100;
//Console.BufferHeight = 25;

// Set position of cursor on 2 row and second column
Console.SetCursorPosition(2, 2);

// Get name and age.
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.Write("Please enter your age: ");
string userAge = Console.ReadLine();


Console.WriteLine($"Your largest window height: {Console.LargestWindowHeight} rows");
Console.WriteLine($"Your largest window width: {Console.LargestWindowWidth} columns");

// Change background color
Console.BackgroundColor = ConsoleColor.White;

// Change echo color, just for fun.
for(int i = 0; i < 15; i++)
{
    Console.ForegroundColor = (ConsoleColor)i;
    // Echo to the console.
    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
}

// Restore background and foreground colors to their defaults;
Console.ResetColor();

Console.WriteLine("Press any key to continue...");
// Wait for keypress
Console.ReadKey();

// This method clears the established buffer and console display area.
Console.Clear();

// This method forces the console to emit a beep of a specified frequency and duration. 
// Console.Beep();

Console.WriteLine("Bye!");
