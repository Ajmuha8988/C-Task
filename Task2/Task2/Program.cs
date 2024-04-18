Console.WriteLine("Введите количество итераций : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 10000 || n < 1)
{
	Console.WriteLine("Введите количество итераций : ");
	n = Convert.ToInt32(Console.ReadLine());

}
int sum = 0;
for (int i = 0; i < n; i++)
{
	Console.WriteLine((i+1) + " итерация");
	int a = Convert.ToInt32(Console.ReadLine());
	sum += a;
}
Console.WriteLine("В сумме получается : " + sum);