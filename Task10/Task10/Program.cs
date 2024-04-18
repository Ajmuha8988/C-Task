using System.ComponentModel.Design;

Console.WriteLine("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 0 || a > Math.Pow(10, 7))
{
	Console.WriteLine("Введите число a : ");
    a = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());
while (b < 0  || b > Math.Pow(10, 7))
{
	Console.WriteLine("Введите число a : ");
	b = Convert.ToInt32(Console.ReadLine());

}
int efk = 0;
int result = 0;
int count = 1;
if (a == 0 && b == 0)
{
	Console.WriteLine("Количество вычитаний : " + 0 +
	"\nРезультат : " + 0);
}
if (a == 0)
{
Console.WriteLine("Количество вычитаний : " + 0 +
"\nРезультат : " + b);
}
if (b == 0)
{
	Console.WriteLine("Количество вычитаний : " + 0 +
"\nРезультат : " + a); 
}
if(a != 0 || b != 0)
{

	if (a > b)
	{
		efk = a - b;
		while (efk != 0)
		{
			if (b < efk)
			{
				efk = efk - b;
				if (a % efk == 0 && b % efk == 0)
				{
					result = efk;

				}

			}
			else
			{
				efk = b - efk;
				b = efk;
				if (efk == 0)
				{

				}
				else
				{
					result = efk;
				}
			}
			count++;
		}
		Console.WriteLine("Количество вычитаний : " + count +
"\nРезультат : " + result);

	}
	if (a < b)
	{
		efk = b - a;
		while (efk != 0)
		{
			if (a < efk)
			{
				efk = efk - a;
				if (a % efk == 0 && b % efk == 0)
				{
					result = efk;

				}
			}
			else
			{
				efk = a - efk;
				a = efk;
				if (efk == 0)
				{

				}
				else
				{
					result = efk;
				}
			}
			count++;
		}
		Console.WriteLine("Количество вычитаний : " + count +
	"\nРезультат : " + result);
	}
}
