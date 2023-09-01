// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число, до которого будут выведены все чётные числа");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (N < 2)
{
    Console.WriteLine("Число должно быть больше либо равно 2");
}
while (count <= N)
{
    Console.Write(count + " ");
    count += 2;
}