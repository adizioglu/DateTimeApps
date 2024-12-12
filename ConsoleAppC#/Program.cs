using System.Globalization;

DateTime today = DateTime.UtcNow;

DateTime birthday = DateTime.Parse("25/12/1961");

DateTime birthday2 = DateTime.ParseExact("25/12/1961", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday.ToString());
Console.WriteLine(birthday2.ToString());

Console.WriteLine(today);
Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));