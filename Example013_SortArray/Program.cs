// See https://aka.ms/new-console-template for more information

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0;i<count;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0;i<array.Length-1;i++)
    {
        int minPosition = i;
        for(int j=i+1;j<array.Length;j++)
        {
            if (array[j]<array[minPosition]) minPosition = j;
        }
        
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
Console.WriteLine("");
ReverseSort(arr);
//SelectionSort(arr);
PrintArray(arr);

//Сделать обратную сортировку: от большего к меньшему.

void ReverseSort(int[] array)
{
    int temp = 0;
    int max = 0;
    for(int i = 0;i<array.Length-1;i++)
    {
        max = i;
        for(int j=i;j<array.Length-1;j++)
        {
            if(array[j]>array[max])
            {
                max = j;
            }
        }
        temp = array[i];
        array[i] = array[max];
        array[max] = temp;

    }



}
