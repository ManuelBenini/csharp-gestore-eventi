
public class ProgramEvents
{
    public string Title { get; set; }

    public List<Event> Events;

    public ProgramEvents(string title)
    {
        Title = title;
        Events = new List<Event>();
    }

    public void EventAdder(Event newEvent)
    {
        Events.Add(newEvent);
    }
    public void EventPrintOnDate(DateTime date)
    {
        bool eventsExistOnDate = false;

        foreach (Event e in Events)
        {
            if(e.Date == date)
            {
                Console.WriteLine(e.Title);
                eventsExistOnDate = true;
            }
        }

        if (!eventsExistOnDate)
        {
            Console.WriteLine("Non esistono eventi nella data scelta.");
        }
        
    }

    public void EventsPrint()
    {
        foreach (Event e in Events)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public int NumberOfEvents()
    {
        return Events.Count;
    }

    public void EventsClear()
    {
        Events.Clear();
    }

    public void ProgramPrint()
    {
        Console.WriteLine($"Eventi presenti nel programma: {Title}");
        EventsPrint();
    }

}