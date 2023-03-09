// Напишите программу, которая перевернет одномерный массив 12345 - 54321

void FillArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
        array[i] = new Random().Next(-100,100);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void Reverse(int[] array)
{
    int temp;
    int size = array.Length;

    for (int i=0; i<size/2; i++)
    {
        /*temp = array[i];
        array[i]=array[size-1-i];
        array[size-1-i]=temp;*/
        (array[i], array[size-1-i]) = (array[size-1-i], array[i]);



    }
}
int [] array = new int[8];
FillArray(array);
PrintArray(array);
Reverse(array);
PrintArray(array);

