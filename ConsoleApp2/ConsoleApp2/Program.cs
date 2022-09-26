using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter nk = ");
            int nk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter nn = ");
            int nn = Convert.ToInt32(Console.ReadLine());
            double p = 1;

            if (0 <= nn && nn <= nk)
            {
                for (int k = nn; k <= nk; k++)
                {
                    p *= Math.Pow(-1, Math.Pow(k, 2) - 2 * k + 3) * (k + 1) / (k * k - 2);
                }
                Console.WriteLine("Добуток числового ряду = " + p);
            }
            else
            {
                Console.WriteLine("<0 <= nn <= nk> не відбувається виконання цієї нерівності!");
            }
            Console.ReadLine();
        }
    }
}