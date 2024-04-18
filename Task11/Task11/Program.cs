Console.WriteLine("Введите возраст : ");
int n = Convert.ToInt32 (Console.ReadLine());
while(n < 0 ||  n > 150)
{
    Console.WriteLine("Введите возраст : ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n < 7)
{
    Console.WriteLine("preschool child"); 
}
if(n > 6 && n < 18)
{
    int m = n - 6;
    Console.WriteLine("schoolchild " + m);
}
if(n > 17 && n < 23)
{
    int m = n - 17;
    Console.WriteLine("student " + m);
}
if(n > 22)
{
    Console.WriteLine("specialist");
}