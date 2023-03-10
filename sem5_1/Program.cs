/*
 Напишите программу замены элементов массива - положительные элементы замените на отрицательные и наоборот
 задайте массив. напишите программу, которая определяет присутствует ли заданное число в массиве */

void FillArray(int [] array)
{
    for (int i=0;i<array.Length;i++)
        array[i] = new Random().Next(-9,10);
}

void FillArray(int [] array)
{
    for (int i=0;i<array.Length;i++)
        array[i] = new Random().Next(-9,10);
}

void ChangeArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    array[i] = -array[i];
    Console.WriteLine();
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);

void FillArray(int [] array)
{
    for (int i=0;i<array.Length;i++)
        array[i] = new Random().Next(-9,10);
}

void PrintArray(int [] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
void FindDigit(int[] array, int n)
{
    bool find = false;
     for (int i=0;i<array.Length;i++)
     {
        if (array[i] == n)
            {find = true; 
            break;
            }
     }
     if (find) 
     Console.WriteLine("Нашли");
     
        else
           Console.WriteLine("Число НЕ присутсвует");
}

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[12];
FillArray(array);
PrintArray(array);
FindDigit(array, n);









