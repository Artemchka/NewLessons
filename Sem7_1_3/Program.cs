// Задайте двумерный массив. Найдите элементы у которых оба индекса четные и замените эти индексы на их квадраты

void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)

    for (int j=0; j<array.GetLength(1);j++)
    array[i,j] = i+j;
}

 void ArrayCward(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    for (int j=0; j<array.GetLength(1);j++)
          if(i % 2 !=0 && j % 2 !=0)
          {
            array[i, j] = array[i, j] * array [i, j];
          }
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
Console.WriteLine();
ArrayCward(array);
PrintArray(array);

