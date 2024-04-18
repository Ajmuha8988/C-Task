Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1 || n > 10000)
{
    Console.WriteLine("Введите число : ");
    n = Convert.ToInt32(Console.ReadLine());
}
List<int> mincount = new List<int>();
for(int i = 0; i < n; i++)
{
    Console.WriteLine((i+1) + " итерация : ");
    int a = Convert.ToInt32((Console.ReadLine())); 
    while(a < -10000 || a > 10000)
    {
        Console.WriteLine((i + 1) + " итерация : ");
        a = Convert.ToInt32((Console.ReadLine()));
    }
    mincount.Add(a);

}
var result = mincount.Count(x =>x ==mincount.Min());
Console.WriteLine("Количество минимумов составляет : " + result);