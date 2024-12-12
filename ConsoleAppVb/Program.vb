Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())

        Dim today As DateTime = DateTime.UtcNow

        Dim birthday As DateTime = DateTime.Parse("25/12/1961")

        Dim birthday2 As DateTime = DateTime.ParseExact("25/12/1961", "d/M/yyyy", CultureInfo.InvariantCulture)

        Console.WriteLine(birthday.ToString())
        Console.WriteLine(birthday2.ToString())

        Console.WriteLine(today)
        Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"))

    End Sub
End Module
