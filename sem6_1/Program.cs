// Создаем двухмерный массив
String [,] table = new string[2, 5];  //задаем массив таблицей: первое число количество строк, второе столбцов (индексы начинают меняться с 0)
/*table [1, 2] = "слово";

for (int rows =0; rows < 2; rows++)
{
    for(int colums =0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/




void PrintArray(int[,] matrix)
{
for (int rows =0; rows < 3; rows++) // for (int rows =0; rows < matrix.GetLength(0); rows++)
{
    for(int colums =0; colums < 4; colums++) // for (int rows =0; rows < matrix.GetLength(1); rows++)
    {
        Console.Write($"{matrix[rows, colums]} ");
    }
Console.WriteLine();
}
}

void Filla(int[,] matrix)
{
for (int rows =0; rows < 3; rows++) // for (int rows =0; rows < matrix.GetLength(0); rows++)
 {
    for(int colums =0; colums < 4; colums++) // for (int rows =0; rows < matrix.GetLength(1); rows++)
    {
        matrix[rows, colums] = new Random().Next(1, 10);
    }
 }
}


int [,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();

Filla(matrix);
PrintArray(matrix);