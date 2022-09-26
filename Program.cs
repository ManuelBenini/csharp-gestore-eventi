

Event newEvent = new Event("Rockstar", new DateTime(2025, 3, 1, 7, 0, 0), 50);

Console.WriteLine(newEvent.Title);
Console.WriteLine(newEvent.Date);
Console.WriteLine(newEvent.MaxCapacity);
Console.WriteLine(newEvent.ToString());

newEvent.BookSeats(50);
Console.WriteLine(newEvent.BookedSeats);

newEvent.CancelSeats(50);
Console.WriteLine(newEvent.BookedSeats);
