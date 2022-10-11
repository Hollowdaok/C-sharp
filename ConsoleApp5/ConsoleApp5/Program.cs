Console.Write("Enter M: ");
int.TryParse(Console.ReadLine(), out int m);
Console.Write("Enter N: ");
int.TryParse(Console.ReadLine(), out int n);

int[,] matrix = new int[m, n];

Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(0, 10);
        Console.Write($"{matrix[i, j],-3}");
    }
    Console.WriteLine();
}

Console.WriteLine($"Different Rows: {FindDifferentRows(matrix)}");
Console.WriteLine($"Different Cols: {FindDifferentCols(matrix)}");

int FindDifferentRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        bool isDifferent = true;
        for (int j = 0; j < columns; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (matrix[i, j] == matrix[i, k])
                {
                    isDifferent = false;
                    break;
                }
            }
            if (!isDifferent) break;
        }
        if (isDifferent) count++;
    }
    return count;
}

int FindDifferentCols(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int count = 0;
    for (int i = 0; i < columns; i++)
    {
        bool isDifferent = true;
        for (int j = 0; j < rows; j++)
        {
            for (int k = j + 1; k < rows; k++)
            {
                if (matrix[j, i] == matrix[k, i])
                {
                    isDifferent = false;
                    break;
                }
            }
            if (!isDifferent) break;
        }
        if (isDifferent) count++;
    }
    return count;
}