Console.WriteLine("Количество последовательностей : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
	Console.WriteLine("Количество последовательностей : ");
	n = Convert.ToInt32(Console.ReadLine());
}
List<int> list = new List<int>();
List<double> two = new List<double>(); 
for (int i = 0; i < n; i++)
{
	double t = Math.Pow(2, i);
	two.Add(t);
}
for (int i = 0; i < n; i++)
{
	
	Console.WriteLine((i + 1) + " Итерация: ");
	int a = Convert.ToInt32(Console.ReadLine());
	if (two.Contains(i+1))
	{
		list.Add(a);
	}
}
int sum = list.Sum();
Console.WriteLine("Искомая сумма : " + sum);