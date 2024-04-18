using System;
Console.WriteLine("Число А :");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B :");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число C :");
double c = Convert.ToInt32(Console.ReadLine());

if(a == 0)
{
    Console.WriteLine("Имеем один корень");
};
double D = Math.Pow(b, 2) - (4 * a * c);

if (D == 0 && a != 0)
{
    Console.WriteLine("Имеем один корень");
}
else if (D > 0 && a != 0)
{
    double x1 = (-b - Math.Sqrt(D)) / (2 * a);
    double x2 = (-b + Math.Sqrt(D)) / (2 * a);
    if (x1 > x2)
    {
        Console.WriteLine("Имеем два корня");
    }
    else
    {
        Console.WriteLine("Имеем два корня");
    }
       
}
