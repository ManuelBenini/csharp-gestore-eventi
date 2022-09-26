
public class ProgramEvent
{
    string Title;

    List<Event> events;

    List<Event> Events { get => events; }

    public ProgramEvent(string title)
    {
        Title = title;
        events = new List<Event>();
    }

    public void EventAdder(Event newEvent)
    {
        Events.Add(newEvent);
    }

    public List<Event> EventPrintOnDate(string date)
    {
        List<Event> events = new List<Event>();

        foreach (Event e in Events)
        {
            if(e.Date.ToString("d") == date)
            {
                events.Add(e);
            }
        }
        return events;
    }

    public static void EventsPrint(List<Event> list)
    {
        foreach (Event e in list)
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

    public string ProgramPrint()
    {
        string programPrint = $"{Title} : \n";

        foreach (Event e in Events)
        {
            programPrint += " - " + e.ToString() + "\n";
        }

        return programPrint;
    }

}