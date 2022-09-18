try
{
    Console.Write("Enter nk: ");
    int nk = int.Parse(Console.ReadLine());

    Console.Write("Enter nn: ");
    int nn = int.Parse(Console.ReadLine());

    Console.WriteLine($"Lemur: {Mathematics.Lemur(nk, nn)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


static class Mathematics
{

    public static double Lemur(int nk, int nn)
    {
        if (nn < 0 || nk < nn) throw new ArgumentException("0 <= nn <= nk");
        double result = 1;
        for (double k = nn; k < nk; k++)
        {
            double numerator = Math.Pow(-1, Math.Pow(k, 2) - 2 * k + 3) * (k + 1);
            double denominator = k * k - 2;
            result *= numerator / denominator;
        }
        return result;
    }

}