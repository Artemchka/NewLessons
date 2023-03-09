// не используя рекурсию выведите первые числа N чисел Фибоначчи. Первые два числа  - 0 и 1

int Vvod(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}
int[] Fibonachi(int num)
{

 int fib =0;
 int[] array = new int[num];
 array[0]=0;
 array[1]=1;

 for(int i =0; i<array.Length; i++)
 {
    array[i] = array[i-1] + array[i-2];
 }
 return array;
}


void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int number = Vvod("Введите число: ");
int[] arrayFib = Fibonachi(number);
PrintArray(arrayFib);



   

