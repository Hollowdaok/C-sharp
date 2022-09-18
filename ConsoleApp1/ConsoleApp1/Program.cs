using System;

class Program
{
    public static void Main(string[] args)
    {
        var ts = TimeSpan.FromSeconds(21356);

        Console.WriteLine("{0} ч. {1} хв. {2} с.", ts.Hours, ts.Minutes, ts.Seconds);

        Console.ReadKey();
    }
}