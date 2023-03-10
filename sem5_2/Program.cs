// Задача 35: Задайте одномерный массив из 12 случайных чисел в диапазоне от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

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

void CountMass(int[] array)
{
    int count =0;
    for (int i=0;i<array.Length;i++)
    if(array[i] >=10 && array[i]<=99)
    count++;
    return;
    Console.WriteLine();
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
CountMass(array);




