using System;

Console.WriteLine("=> Data Declarations:");
// dataType variableName = initialValue;
int myInt = 0;
string myString;
string someString = "Some string";

// You can also declare and assign on two lines.
string tutorialName;
tutorialName = "From zero to hero";

// You can also declare multiple variables
// of the same underlying type on a single line of code
bool isMidnight = false, isNoon = true, isNight = isMidnight;

// Be aware that it is a compiler error
// to make use of a local variable
// before assigning an initial value
//int uninitializedInt;
//Console.WriteLine(uninitializedInt);

int myIntDefault = default;
string myStringDefault = default;
bool isMidnightDefault = default;

System.Console.WriteLine();

// Constructors will be covered in feature lection
int myIntCtor = new int(); // set value to 0
string myStringCtor = new string(' ', 1); // init string with one space(" ")
bool isMidnightCtor = new bool(); // set value to false

System.Console.WriteLine();
