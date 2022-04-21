// : Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
Console.Clear();

int firstNum;
int secondNum;

Console.Clear();

Console.WriteLine("Введите первое число");
firstNum=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
secondNum=Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    int max = firstNum;
    int min = secondNum;
  Console.WriteLine("Ответ");
  Console.WriteLine($"{max} > {min}");
}
else
{
     int max = secondNum;
     int min = firstNum;
    Console.WriteLine("Ответ");
    Console.WriteLine($"{min} < {max}");
}
