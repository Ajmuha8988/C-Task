Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > Math.Pow(10, 9))
{
	Console.WriteLine("Введите число");
	n = Convert.ToInt32(Console.ReadLine());

}
List<int> numbers= new List<int>();
int a = 0;
while (n != 1)
{
	a = n % 2;
	n = n / 2;
	numbers.Add(a);
}
numbers.Add(n);
numbers.Reverse();
string concat = string.Join("", numbers.ToArray());
int count = concat.Length - concat.TrimEnd('0').Length;
Console.WriteLine("Количество нулей в конце двойчной системе составляет : " + count);