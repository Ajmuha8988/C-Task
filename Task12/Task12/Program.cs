Console.WriteLine("Введите число a1 : ");
int a1 = Convert.ToInt32(Console.ReadLine());
while(a1 < 1 || a1 > 1000)
{
    Console.WriteLine("Введите число a1 : ");
    a1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());
while (b1 < 1 || b1 > 1000)
{
    Console.WriteLine("Введите число b1 : ");
    b1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число a2 : ");
int a2 = Convert.ToInt32(Console.ReadLine());
while (a2 < 1 || a2 > 1000)
{
    Console.WriteLine("Введите число a2 : ");
    a2 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число b2 : ");
int b2 = Convert.ToInt32(Console.ReadLine());
while (b2 < 1 || b2 > 1000)
{
    Console.WriteLine("Введите число b2 : ");
    b2 = Convert.ToInt32(Console.ReadLine());
}
if (((a1 + a2 == b1) && (b1 == b2))
    || ((a1 + b2 == b1)&&(b1 == a2))
    ||((b1 + a2 == a1)&& (a1 == b2))
    ||((b1 + b2 == a1)&&(a1 == a2)))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}