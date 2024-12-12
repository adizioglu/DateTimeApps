open System
open System.Globalization

let today = DateTime.UtcNow

let birthday = DateTime.Parse("25/12/1961")

let birthday2 = DateTime.ParseExact("25/12/1961", "d/M/yyyy", CultureInfo.InvariantCulture)

printfn "%s" (birthday.ToString())
printfn "%s" (birthday2.ToString())

printfn "%s" (today.ToString())
printfn "%s" (today.ToString("MMMM dd, yyyy hh:mm tt zzz"))
