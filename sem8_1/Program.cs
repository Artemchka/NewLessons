// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива (Задайте двумерный массив.  Напишите программу которая заменяет все строки на столбцы)


void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    for (int j=0; j<array.GetLength(1);j++)
    array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
}

void PrintArray(int[,] array)
{
     for(int i=0; i <array.GetLength(0) ; i++)
     {
    for ( int j=0; j<array.GetLength(1);j++)

     Console.Write($"{array[i,j],3} \t");
    Console.WriteLine();
     }
}


void ChangeMass(int[,] array)
{
    for (int j=0; j<array.GetLength(1);j++)
    {
    (array[0, j], array[array.GetLength(0) -1,j]) = (array[array.GetLength(0) -1, j], array[0, j]);
    } 
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeMass(array);
PrintArray(array);
