Console.WriteLine("Введите число не меньше 1 : ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1)
{
	Console.WriteLine("Введите число не меньше 1 : ");
	a = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число не больше 1000 : ");
int b = Convert.ToInt32(Console.ReadLine());
while (b > 1000)
{
	Console.WriteLine("Введите число не больше 1000 : ");
	b = Convert.ToInt32(Console.ReadLine());
}
int sum = a + b;
Console.WriteLine("Cумма из чисел " + a + " и " + b + " составляет " + sum);