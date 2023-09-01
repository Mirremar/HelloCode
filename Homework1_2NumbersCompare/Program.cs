// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;
Console.WriteLine("Введите два целых числа");
Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else if (a == b)
    {
        Console.WriteLine("max = min = " + a);
    }
    else
    {
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
    }