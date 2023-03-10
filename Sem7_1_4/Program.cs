// Задайте двумерный массив. Найдите сумму элементов находящихся на главной и обратной диагонали

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
Console.WriteLine(ArraySum(array, rows));

  string ArraySum(int[,] array, int n)
    {
     int result1 = 0;
     int result2 = 0;
     string res ="";
     for(int i=0; i < array.GetLength(0); i++)
      for ( int j=0; j<array.GetLength(1);j++)
      if(i ==j)
      {
        result1 += array[i, j];
        if(i + j == n-1)
        result2 += array[i, j];
      }
      res = $"Результат по прямой диагонали = {result1} \nРезультат по прямой диагонали = {result2}";
      return res;
    }