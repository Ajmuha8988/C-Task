Console.WriteLine("Введите число итерации : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
	Console.WriteLine("Введите число итерации : ");
	n = Convert.ToInt32(Console.ReadLine());
}
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
	Console.WriteLine((i+1) + " Итерация");
	int a = Convert.ToInt32(Console.ReadLine());
	while (a < -10000 || a > 10000)
	{
		Console.WriteLine((i + 1) + " Итерация");
		a = Convert.ToInt32(Console.ReadLine());
	}
	list.Add(a);
}
int[] ints = list.ToArray();
int indexMin = Array.IndexOf(ints, ints.Min());
Console.WriteLine("Минимальный индекс : " + indexMin);
