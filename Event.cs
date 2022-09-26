// See https://aka.ms/new-console-template for more information
public class Event
{
    string title;
    public string Title
    {
        get => title;
        set
        {
            try
            {
                if (value == "")
                {
                    title = "Undefined title";
                    throw new Exception("Non è possibile inserire un titolo vuoto");
                }
                else
                {
                    title = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    DateTime date;
    public DateTime Date
    {
        get => date;
        set
        {
            try
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("La data dell'evento non può essere precedente alla data attuale");
                }
                else
                {
                    date = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }

    int maxCapacity;

    public int MaxCapacity
    {
        get => maxCapacity;

        private set
        {
            try
            {
                if (value < 0)
                {
                    throw new Exception("La capacità massima dell'evento non può essere minore di 0");
                }
                else
                {
                    maxCapacity = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public int bookedSeats;

    public int BookedSeats
    {
        get => bookedSeats;

        private set
        {
            bookedSeats = value;
        }
    }

    public Event(string title, DateTime date, int maxCapacity)
    {
        Title = title;
        Date = date;
        MaxCapacity = maxCapacity;
        BookedSeats = 0;
    }

    public void BookSeats(int n)
    {
        try
        {
            if (Date < DateTime.Now)
            {
                throw new Exception("La data dell'evento non può essere precedente alla data attuale");
            }
            else if (BookedSeats >= maxCapacity)
            {
                throw new Exception("Non ci sono più posti prenotabili per l'evento");
            }
            else if(n > MaxCapacity)
            {
                throw new Exception("I posti che si vogliono prenotare superano la capacità massima dell'evento");
            }
            else if(n > maxCapacity - BookedSeats)
            {
                throw new Exception("Si vogliono prenotare più posti di quanti ce ne siano disponibili");
            }
            else
            {
                BookedSeats += n;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

    public void CancelSeats(int n)
    {
        try
        {
            if (Date < DateTime.Now)
            {
                throw new Exception("La data dell'evento non può essere precedente alla data attuale");
            }
            else if (n > BookedSeats)
            {
                throw new Exception("Non è possibile disdire più posti di quanto ce ne siano prenotati");
            }
            else
            {
                BookedSeats -= n;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public override string ToString()
    {
        string dateAndTitle = Date.ToString("dd/MM/yyyy") + " - " + Title;
        return dateAndTitle;
    }
}