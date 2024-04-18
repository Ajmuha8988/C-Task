using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Введите число : ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 1 || n > 10000)
        {
            Console.WriteLine("Введите число : ");
            n = Convert.ToInt32(Console.ReadLine());

        }
        List<double> proct = new List<double>();
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                proct.Add(i);
            }
        }
        proct.ForEach(Console.WriteLine);
    }
}