using System;
using System.Collections.Generic;
class GFG
{   
    public static void Main(String[] args)
    {
        int[,] mat = {{ 1, 1, 1 },
                      { 1, 2, 1 },
                      { 1, 1, 2 }};
        Console.WriteLine(countRows(mat));
        Console.WriteLine(countColumn(mat));
    }

    public static int countRows(int[,] mat)
    {
        int count = 0;

        for (int i = 0;
                 i < mat.GetLength(0); i++)
        {


            HashSet<int> hs = new HashSet<int>();


            for (int j = 0;
                     j < mat.GetLength(0); j++)
            {


                hs.Add(mat[i, j]);
            }


            if (hs.Count != 1)
                count++;
        }
        return count;
    }
    public static int countColumn(int[,] mat)
    {
        int bcount = 0;

        for (int j = 0;
                 j < mat.GetLength(0); j++)
        {

            HashSet<int> hs = new HashSet<int>();


            for (int i = 0;
                     i < mat.GetLength(0); i++)
            {


                hs.Add(mat[i, j]);
            }


            if (hs.Count != 1)
                bcount++;
        }
        return bcount;
    }


}