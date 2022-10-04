Console.WriteLine("Введіть число: ");
string str1 = Console.ReadLine();
char[] ch = str1.ToCharArray();
Array.Reverse(ch);
string str2 = new string(ch);
if (str1 == str2)
    Console.WriteLine("Дане число читається одинаково зліва направо і навпаки(TRUE)");
else
    Console.WriteLine("Дане число не читається одинаково зліва направо і навпаки(FALSE)");