
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

//ProgramEvent newProgram = new ProgramEvent("Giochi d'autunno");

//newProgram.EventAdder(new Event("Rockstar", new DateTime(2023, 3, 1, 7, 0, 0), 150));

//newProgram.EventAdder(new Event("Barbablù", new DateTime(2023, 3, 1, 7, 0, 0), 150));

//newProgram.EventPrintOnDate(new DateTime(2023, 3, 1, 7, 0, 0));

//newProgram.EventsPrint();

//Console.WriteLine(newProgram.NumberOfEvents());

//newProgram.ProgramPrint();

//newProgram.EventsClear();

//Console.WriteLine(newProgram.NumberOfEvents());



ProgramEvent newProgram = new ProgramEvent("Giochi d'autunno");

newProgram.EventAdder(new Event("Rockstar", new DateTime(2023, 3, 11, 7, 0, 0), 150));
newProgram.EventAdder(new Event("Barbablù", new DateTime(2023, 3, 12, 7, 0, 0), 150));

List<Event> list = newProgram.EventPrintOnDate("11/03/2023");

Console.WriteLine("Lista eventi nella data scelta: ");
ProgramEvent.EventsPrint(list);

Console.WriteLine();

Console.WriteLine("Numero di eventi nel programma");
Console.WriteLine(newProgram.NumberOfEvents());

Console.WriteLine();
Console.WriteLine(newProgram.ProgramPrint());

Console.WriteLine();
Console.WriteLine("Svuotata lista eventi");
newProgram.EventsClear();

Console.WriteLine();
Console.WriteLine("Numero di eventi nel programma");
Console.WriteLine(newProgram.NumberOfEvents());