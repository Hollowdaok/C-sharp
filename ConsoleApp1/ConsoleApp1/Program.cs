Console.Write("Введіть час в секундах : ");
int n = Int32.Parse(Console.ReadLine());
int hour = n / 3600;
int min = (n - hour * 3600) / 60;
int sec = n - hour * 3600 - min * 60;
Console.WriteLine("\n{0} сек. мають : {1} год. {2} хв. {3} сек.", n, hour, min, sec);

Console.ReadKey();