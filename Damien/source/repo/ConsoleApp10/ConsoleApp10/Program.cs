using System;

class HoursOutOfRangeException : Exception
{
    public HoursOutOfRangeException(string name, string value)
        :base($"{name} doit etre compris entre 0 et 24 (saisie: {value})")
    {

    }

}
class MinutesOutOfRangeException : Exception
{
    public MinutesOutOfRangeException(string name, string value)
        : base($"{name} doit etre compris entre 0 et 60 (saisie: {value})")
    {

    }

}
class TimePeriod
{
    private double _seconds;

    public double Minutes
    {
        get { return _seconds / 60; }
        set
        {
            if (value < 0 || value > 60)
            {
                //throw new OutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                throw new MinutesOutOfRangeException(nameof(Minutes), Convert.ToString(value));
            }
            _seconds = value * 60;
        }
    }

    public double Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
            {
                //throw new OutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                throw new HoursOutOfRangeException(nameof(Hours), Convert.ToString(value));
            }
            _seconds = value * 3600;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Minutes = 60;
            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in minutes: {t.Minutes}");

            t.Hours = 25;
            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in hours: {t.Hours}");


        }
        catch (Exception e) when (e is MinutesOutOfRangeException || e is HoursOutOfRangeException)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }

        Console.ReadKey();
    }
}
// The example displays the following output:
// Time in minutes: 60
// Hours doit etre compris entre 0 et 24 (saisie: 25)