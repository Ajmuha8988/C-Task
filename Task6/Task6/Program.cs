Console.Write("Введите длину : ");
double n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
	Console.Write("Введите длину : ");
    n = Convert.ToInt32(Console.ReadLine());
}
double funt = n / (12 * 3);
double dyum = n % 36;
int funt1 = Convert.ToInt32(funt);
int c = Convert.ToInt32(dyum);
int dyum1 = c / 3;


Console.WriteLine(funt1 + " Фута " + dyum1 + " дюйма");
