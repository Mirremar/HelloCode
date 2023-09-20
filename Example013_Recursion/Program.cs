// See https://aka.ms/new-console-template for more information

string[,] table = new string[2, 5];
//table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
//table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

table[1, 2] = "Слово";

/*for (int rows = 0;rows<2;rows++)
{
    for (int columns = 0;columns<5;columns++)
    {
        Console.WriteLine($"—{table[rows,columns]}—");
    }
}*/

int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"—{matrix[rows, columns]}—");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,10); //[1,10)
        }
        Console.WriteLine();
    }
}



PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);