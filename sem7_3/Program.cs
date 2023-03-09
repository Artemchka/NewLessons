// // Напишите программу которая будет преобразовывать десятичное число в двоичное

void Change(int number)
{
  string i="";

  while(number > 0)
  {
    i = number % 2 + i;
    number /= 2;
  }
Console.WriteLine(i);
}

Console.WriteLine("Введите десятичное число:\t");
int number = Convert.ToInt32(Console.ReadLine());

Change(number);
