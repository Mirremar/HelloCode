// See https://aka.ms/new-console-template for more information
int[] numbers = {1,3,6,8,5};
int i = 0;
int max = numbers[0];
while (i < numbers.Length) 
{
    if (numbers[i] > max)
    {
    max = numbers[i];
    }
    i++;

}
Console.WriteLine(max);