int number = 0;
do
{
    Console.Write("Enter number: ");
    int.TryParse(Console.ReadLine(), out number);
} while (number < 1000 || number > 9999);

Console.WriteLine($"Number is {(CheckNumber(number) ? "symmetric(true)" : "not symmetric(false)")}");

bool CheckNumber(int n)
{
    int[] digits = new int[4];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = n % 10;
        n /= 10;
    }
    return digits[0] == digits[3] && digits[1] == digits[2];
}