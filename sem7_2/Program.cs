// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с сторонами такой длины (теорема треугольника - каждая сторона треугольника меньшетсуммы двух ьего других сторон)
// Напишите программу которая будет преобразовывать десятичное число в двоичное

void check(int a, int b, int c)
{
    if(a+b>c && a+c>b)
    Console.WriteLine("Такой треугольник может существовать");
    else
    Console.WriteLine("Такой треугольник НЕ может существовать");
}

Console.WriteLine("Введите длину сторон треугольника A:\t");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину сторон треугольника B:\t");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину сторон треугольника C:\t");
int c = Convert.ToInt32(Console.ReadLine());

check(a, b, c);
