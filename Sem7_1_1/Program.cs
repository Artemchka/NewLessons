// двухмерные массивы. Задайте двумерный массив размером м на н, заполненный случайными целыми числами

void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)

    for (int j=0; j<array.GetLength(1);j++)
    array[i,j] = new Random().Next(-20, 21);
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

