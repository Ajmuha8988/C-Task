Console.WriteLine("Введите количество итерации :");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
	Console.WriteLine("Введите количество итерации :");
	n = Convert.ToInt32(Console.ReadLine());
}
int a = 0;
int b = 0;
int sum = 0;
int suma = 0;
int sumb = 0;
for (int i = 0; i < n; i++)
{
	Console.WriteLine((i + 1) + " итерация ");
	if(i % 2 == 0)
	{
		a = Convert.ToInt32(Console.ReadLine());
		suma += a;
	}
	else
	{
		b = Convert.ToInt32(Console.ReadLine());
		sumb -= b;
	}
}
sum = suma + sumb;
Console.WriteLine(" Альтернированная сумма " + n + " итерации составляет " + sum);

