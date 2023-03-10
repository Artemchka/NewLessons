// Задайте двумерный массив размера м на н, каждый элемент в массиве находится по формуле а=м+н Выведите полученный массив на экран

void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)

    for (int j=0; j<array.GetLength(1);j++)
    array[i,j] = i+j;
}

void PrintArray(int[,] array)
{
     for(int i=0; i < array.GetLength(0); i++)
     {
    for ( int j=0; j<array.GetLength(1);j++)
     Console.Write($"{array[i,j],3} \t");
    Console.WriteLine();
     }

}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);