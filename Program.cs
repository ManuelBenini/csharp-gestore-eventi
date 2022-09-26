
Console.Write("Salve! Inserisci il nome dell'evento: ");
string eventTitle = Console.ReadLine();

Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserisci numero di posti totali: ");
int eventCapacity = Convert.ToInt32(Console.ReadLine());

Event newEvent = new Event(eventTitle, eventDate, eventCapacity);

Console.Write("Quanti posti desideri prenotare? ");
newEvent.BookSeats(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine(newEvent.BookedSeats);
