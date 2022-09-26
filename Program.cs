
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Inserisci il nome del tuo programma Eventi: ");
ProgramEvent newProgram = new ProgramEvent(Console.ReadLine());

Console.Write("Indica il numero di eventi da inserire: ");
int numberOfEventsToAdd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();
for (int i = 1; i <= numberOfEventsToAdd; i++)
{
    Console.WriteLine("Vuole inserire una Conferenza(0) o un evento(1)?");

    switch (Convert.ToInt32(Console.ReadLine()) )
    {
        case 0:
            bool conferenceErrors = false;

            while (!conferenceErrors)
            {
                try
                {
                    conferenceErrors = true;

                    Console.Write($"Inserisci il nome del {i}° evento (conferenza): ");
                    string eventTitle = Console.ReadLine();

                    Console.Write("Inserisci data della conferenza (gg/mm/yyyy): ");
                    DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Inserisci numero di posti totali: ");
                    int eventCapacity = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inserisci il nome del presentatore: ");
                    string conferenceSpeaker = Console.ReadLine();

                
                    bool isPriceValid = false;
                    string eventPrice = "";

                    while (!isPriceValid)
                    {
                        isPriceValid = true;

                        Console.Write("Inserisci il prezzo del biglietto (00,00): ");
                        eventPrice = Console.ReadLine();

                        if (!Double.TryParse(eventPrice, out double result))
                        {
                            isPriceValid = false;
                            Console.WriteLine("Il prezzo non è stato inserito correttamente");
                        }
                    }

                    Event newConference = new Conference(eventTitle, eventDate, eventCapacity, conferenceSpeaker, Convert.ToDouble(eventPrice) );
                    newProgram.EventAdder(newConference);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    conferenceErrors = false;
                }
            }
            break;

        default:
            bool eventErrors = false;

            while (!eventErrors)
            {

                eventErrors = true;

                Console.Write($"Inserisci il nome del {i}° evento: ");
                string eventTitle = Console.ReadLine();

                Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
                DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Inserisci numero di posti totali: ");
                int eventCapacity = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Event newEvent = new Event(eventTitle, eventDate, eventCapacity);
                    newProgram.EventAdder(newEvent);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    eventErrors = false;
                }
            }
            break;
    }


    
    

    Console.WriteLine();
    Console.WriteLine();
    //Console.Write("Quanti posti desideri prenotare? ");
    //newEvent.BookSeats(Convert.ToInt32(Console.ReadLine()));

    //Console.WriteLine(newEvent.BookedSeats);
}

Console.WriteLine($"Il numero di eventi nel programma è {newProgram.NumberOfEvents()}");

Console.WriteLine("Ecco il tuo programma eventi:");

Console.WriteLine(newProgram.ProgramPrint()); 

Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");

List<Event> list = newProgram.EventPrintOnDate(Console.ReadLine());

ProgramEvent.EventsPrint(list);

//newProgram.EventsClear();
