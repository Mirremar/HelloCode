// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;
int c = 0;
Console.WriteLine("Введите три числа");
Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите с");
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine("Максимум трёх чисел равен " + max);