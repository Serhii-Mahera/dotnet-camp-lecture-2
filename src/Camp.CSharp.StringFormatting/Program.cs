using System;

var simpleString = "This is simple string \n\tIt is not ignore character escapes";
Console.WriteLine(simpleString);

var verbatimString = @"This is verbatim string. \n\t It ignores character escapes \n";
Console.WriteLine(verbatimString);

var multistring = @"
        We can also init multistring
        with verbatim identifier.
        Any special symbols is ignored here \n
";
Console.WriteLine(multistring);

var name = "Antony";
var age = 35;
var formattedString = string.Format("My name is {0}  and my age is {1} y. o.\n", name, age);
Console.WriteLine(formattedString);
var interpolatedString = $"My name is {name}  and my age is {age} y. o. \n";
Console.WriteLine(interpolatedString);
