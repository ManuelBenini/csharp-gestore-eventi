
using System.Diagnostics;

public class Conference : Event
{
    public string speaker;
    public string Speaker
    {
        get => speaker;
        set
        {
            if (value == "")
            {
                throw new Exception("È obbligatorio inserire il nome del relatore");
            }
            else
            {
                speaker = value;
            }

        }
    }
    public double price;
    public double Price
    {
        get => price;
        set
        {
            if (value < 0)
            {
                throw new Exception("È obbligatorio inserire il prezzo");
            }
            else
            {
                price = value;
            }

        }
    }

    public Conference(string title, DateTime date, int maxCapacity, string speaker, double price) : base(title, date, maxCapacity)
    {
        Speaker = speaker;
        Price = price;
    }

    public string GetDate()
    {
        return Date.ToString("d");
    }

    public string GetPrice()
    {
        return Price.ToString("0.00");
    }

    public override string ToString()
    {
        string fullEventDetails = $"{GetDate()} - {Title} - {Speaker} - {GetPrice()}€";
        return fullEventDetails;
    }
}