class Program
{
    static void Main()
    {
        int a, b;
        while (true)
        {
            Console.WriteLine("Введите число A : ");
            a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Введите число B : ");
            b = Convert.ToInt32 (Console.ReadLine());
            // Чтение входных данных

            if ( a > b || a <= 0 || b >= 5000)
            {
                Console.WriteLine("Некорректный ввод");
                break;
            }

            int maxDivisorsCount = 0;
            int[] numbersWithMaxDivisors = new int[0];

            for (int i = a; i <= b; i++)
            {
                int divisorsCount = CountDivisors(i);
                if (divisorsCount > maxDivisorsCount)
                {
                    maxDivisorsCount = divisorsCount;
                    numbersWithMaxDivisors = new int[] { i };
                }
                else if (divisorsCount == maxDivisorsCount)
                {
                    numbersWithMaxDivisors = numbersWithMaxDivisors.Concat(new int[] { i }).ToArray();
                }
            }

            // Вывод результатов
            Console.WriteLine(numbersWithMaxDivisors.Length);
            foreach (var number in numbersWithMaxDivisors)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine();
        }
    }

    static int CountDivisors(int n)
    {
        int count = 0;
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                // Если делители разные, учитываем оба
                if (n / i == i)
                {
                    count++;
                }
                else
                {
                    count += 2;
                }
            }
        }
        return count;
    }
}
