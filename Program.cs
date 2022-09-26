
//Console.Write("Salve! Inserisci il nome dell'evento: ");
//string eventTitle = Console.ReadLine();

//Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
//DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

//Console.Write("Inserisci numero di posti totali: ");
//int eventCapacity = Convert.ToInt32(Console.ReadLine());

//Event newEvent = new Event(eventTitle, eventDate, eventCapacity);

//Console.Write("Quanti posti desideri prenotare? ");
//newEvent.BookSeats(Convert.ToInt32(Console.ReadLine()));

//Console.WriteLine(newEvent.BookedSeats);

ProgramEvents newProgram = new ProgramEvents("Giochi d'autunno");

newProgram.EventAdder(new Event("Rockstar", new DateTime(2023, 3, 1, 7, 0, 0), 150));

newProgram.EventAdder(new Event("Barbablù", new DateTime(2023, 3, 1, 7, 0, 0), 150));

newProgram.EventPrintOnDate(new DateTime(2023, 3, 1, 7, 0, 0));

newProgram.EventsPrint();

Console.WriteLine(newProgram.NumberOfEvents());

newProgram.ProgramPrint();

newProgram.EventsClear();

Console.WriteLine(newProgram.NumberOfEvents());
