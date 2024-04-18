using System;

class Program
{
    static void Main()
    {
        int[][] BookRack = new int[15][];
        int d = 1;
        Console.WriteLine("Введи номер книги : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0, c = 1; i < 15; i++, c++)
        {
            BookRack[i] = new int[c];
            for (int j = 0; j < c; j++)
                BookRack[i][j] = d++;
        }

        Console.WriteLine(GetRack(BookRack, n));
    }
    static int GetRack(int[][] racks, int n)
    {
        for (int i = 0; i < racks.Length; i++)
            if (racks[i].Contains(n))
                return i + 1;
        return -1;
    }
}
