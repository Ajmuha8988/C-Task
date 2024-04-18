using System.Linq;

Console.WriteLine("Количество предметов : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
	Console.WriteLine("Количество предметов : ");
	n = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("Cуммарная масса : ");
int w =  Convert.ToInt32(Console.ReadLine());
while (w < 1 || w > 10000)
{
	Console.WriteLine("Cуммарная масса : ");
	w = Convert.ToInt32(Console.ReadLine());

}
List<int> list = new List<int>();
for (int i = 0;  i < n; i++)
{
	Console.WriteLine((i + 1) + " Итерация : ");
	int a = Convert.ToInt32(Console.ReadLine());
	while(a > w || a < 1 || a > 10000)
	{
		Console.WriteLine((i + 1) + " Итерация : ");
		a = Convert.ToInt32(Console.ReadLine());

	}
	list.Add(a);
	list.Sort();
	int sum = list.Sum();
	if (sum > w)
	{
		list.Remove(list.Max());
	}
}
int count = list.Count;
int sum1 = list.Sum();
Console.WriteLine("Количество погруженных элементов составляет : " + 
	count + ", А их суммарная масса составляет : " + sum1);


