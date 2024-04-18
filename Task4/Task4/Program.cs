Console.WriteLine("Введите год : ");
int y = Convert.ToInt32(Console.ReadLine());
while(y < 1000 || y > 2100)
{
	Console.WriteLine("Введите год : ");
	y = Convert.ToInt32(Console.ReadLine());
}
if ((y % 4 == 0 && y % 100 != 0 ) || y % 400 == 0)
{
	Console.WriteLine("Вывод : " + 1);
}
else
{
	Console.WriteLine("Вывод : " + 0);
}
