Console.WriteLine("Введите количество итерации: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 1;
do
{
    if (n > i)
    {
        if (i % 2 != 0)
        {
            for (int b = 0; b < i; b++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum + a;
            }
            n = n - i;
            i = i + 1;
        }
        else
        {
            for (int b = 0; b < i; b++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum - a;
            }
            n = n - i;
            i = i + 1;
        }
    }
    else
    {
        if (i % 2 != 0)
        {
            for (int b = 0; b < n; b++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum + a;
            }
            n = n - i;
            i = i + 1;
        }
        else
        {
            for (int b = 0; b < n; b++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum - a;
            }
            n = n - i;
            i = i + 1;
        }
    }
}while(n > 0);
Console.WriteLine(sum);