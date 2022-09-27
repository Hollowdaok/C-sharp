using System;

class Program
{
    static void Main()
    {
        double[] Numbers = { -8, 4, -2, 1 };
        RaD ap = CheckForArithmetic(Numbers);
        RaD gp = CheckForGeometry(Numbers);
        Console.Write(ap.result + " " + ap.difference + "\n");
        Console.Write(gp.result + " " + gp.difference + "\n");
        Console.ReadLine();
    }

    static RaD CheckForArithmetic(double[] Array)
    {
        double _difference = Array[1] - Array[0];
        for (int i = 2; i < Array.Length; i++)
        {
            if (Array[i] - Array[i - 1] != _difference)
                return new RaD(false, 0);
        }
        _difference = Array[Array.Length - 1] - Array[Array.Length - 2];
        return new RaD(true, _difference);
    }

    static RaD CheckForGeometry(double[] Array)
    {
        double _difference = Array[1] / Array[0];
        for (int i = 2; i < Array.Length; i++)
        {
            if (Array[i] / Array[i - 1] != _difference)
                return new RaD(false, 0);
        }
        _difference = Array[Array.Length - 1] / Array[Array.Length - 2];
        return new RaD(true, _difference);
    }
}

class RaD
{
    public bool result;
    public double difference;
    public RaD(bool Result, double Difference)
    {
        result = Result;
        difference = Difference;
    }
}
