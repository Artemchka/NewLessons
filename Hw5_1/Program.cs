// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
        array[i] = new Random().Next(99,999);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}



int[] array = new int[12];
int count =0;

void Chetn(int[] array)
{
for (int i=0;i<array.Length; i++)
if(array[i]%2==0)
 count++;
    return;
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
Chetn(array);