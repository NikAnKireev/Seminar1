// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
Console.Clear();

Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine());

if (N%2==0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
