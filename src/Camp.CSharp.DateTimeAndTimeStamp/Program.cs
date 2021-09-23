using System;
using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.Unicode;
CultureInfo uaCulture = CultureInfo.GetCultureInfo("uk-UA");
CultureInfo enCulture = CultureInfo.GetCultureInfo("en-US");

Console.WriteLine("=> Dates and Times:");

// This constructor takes (year, month, day).
DateTime dt = new DateTime(2021, 09, 23);

// What day of the month is this?
Console.WriteLine("Now is {0} . UTC now date {1}", DateTime.Now, DateTime.UtcNow);

// How many days in current month
Console.WriteLine("There are {0} days in {1}", DateTime.DaysInMonth(dt.Year, dt.Month), dt.ToString("MMMM", enCulture));
// The same using Ukrainian culture
Console.WriteLine("{1} має {0} днів", DateTime.DaysInMonth(dt.Year, dt.Month), dt.ToString("MMMM", uaCulture));

// What day of the month is this?
Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

// Month is now November.
dt = dt.AddMonths(2);
Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

// This constructor takes (hours, minutes, seconds).
TimeSpan ts = new TimeSpan(4, 30, 0);
Console.WriteLine(ts);

// Subtract 15 minutes from the current TimeSpan and
// print the result.
Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

// Get time zone by specific id
TimeZoneInfo cestTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");

// Convert current date and time to Central Europe Time
DateTime cestNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cestTimeZone);
Console.WriteLine("Central Europe Standard Time: {0}", cestNow);

DateTimeOffset offset = DateTimeOffset.ParseExact("08/12/1992 07.00.00 -05:00",
    "dd/MM/yyyy HH.mm.ss zzz", CultureInfo.InvariantCulture);

Console.WriteLine(offset.ToString(uaCulture));
Console.WriteLine(offset.ToString(enCulture));

