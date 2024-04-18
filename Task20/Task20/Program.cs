Console.WriteLine("Количество итерации : ");
int n = Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int> { };
for(int i = 0; i < n; i++)
{
    Console.WriteLine((i + 1) + " Итераций");
    int a = Convert.ToInt32(Console.ReadLine());
    list.Add(a);
}
list.Sort();
int maxCount = -1, maxCountKey = 0;
int currCount = 0, currCountKey = list[0];
foreach (int curr in list)
{
    if (curr == currCountKey)
        currCount++;
    else
    {
        currCount = 1;
        currCountKey = curr;
    }
    if (currCount > maxCount)
    {
        maxCount = currCount;
        maxCountKey = curr;
    }
}
Console.WriteLine($"Число, которое больше всего повторяется: {maxCountKey}. Количество его повтора: {maxCount}");