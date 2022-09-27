Console.WriteLine("Введіть чотиризначне число: ");
string str1 = Console.ReadLine();
char[] ch = str1.ToCharArray();
Array.Reverse(ch);
string str2 = new string(ch);
if (str1 == str2)
    Console.WriteLine("Дане чотиризначне число читається одинаково зліва направо і навпаки");
else
    Console.WriteLine("Дане чотиризначне число не читається одинаково зліва направо і навпаки");
