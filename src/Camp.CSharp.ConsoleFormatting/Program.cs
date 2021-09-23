using System;
using System.Globalization;
string line = new string('-', 64);
// Set using culture to en-US
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
// Change encoding to Unicode in order to echo '₴' sign in console
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Uncomment to list all culture names
//foreach(var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
//{
//    Console.WriteLine($"{item.Name}; {item.TwoLetterISOLanguageName}");
//} 

Console.WriteLine(@"
    Just an example of
    multiline text
    using '@' identifier
");

Console.WriteLine(line);
Console.WriteLine(String.Format("|{0,62}|", "Compare English and Ukrainian cultures output"));
Console.WriteLine(line);

Console.WriteLine("|{0,20}|{1,20}|{2,20}|", "Format", "en-US", "uk-UA");

Console.WriteLine(line);

Console.WriteLine($"|{"c format:",20}|{ 99999,20:c}|{99999.ToString("c", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"d9 format:",20}|{ 99999,20:d9}|{99999.ToString("d9", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"f3 format:",20}|{ 99999,20:f3}|{99999.ToString("f3", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"f6 format:",20}|{ 99999,20:f6}|{99999.ToString("f6", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"E format:",20}|{ 99999,20:E}|{99999.ToString("E", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"e format:",20}|{ 99999,20:e}|{99999.ToString("e", CultureInfo.GetCultureInfo("uk-UA")),20}|");
// Notice that upper- or lowercasing for hex
// determines if letters are upper- or lowercase.s
Console.WriteLine($"|{"X format:",20}|{ 99999,20:X}|{99999.ToString("X", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"x format:",20}|{ 99999,20:x}|{99999.ToString("x", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"n format:",20}|{ 99999,20:n}|{99999.ToString("n", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"g format:",20}|{ 99999,20:g}|{99999.ToString("g", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"p format:",20}|{ 0.895,20:p}|{0.895.ToString("p", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"p3 format:",20}|{ 0.895,20:p1}|{0.895.ToString("p1", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"00.000 format:",20}|{ 1.99,20:00.000}|{1.99.ToString("00.000", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"00.000 format:",20}|{ 99999,20:00.000}|{99999.ToString("00.000", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"##.### format:",20}|{ 1.99,20:##.###}|{1.99.ToString("##.###", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"##.### format:",20}|{ 99999,20:##.###}|{99999.ToString("##.###", CultureInfo.GetCultureInfo("uk-UA")),20}|");
Console.WriteLine($"|{"#0.### format:",20}|{ 1.99,20:#0.###}|{1.99.ToString("#0.###", CultureInfo.GetCultureInfo("uk-UA")),20}|");

Console.WriteLine(line);
