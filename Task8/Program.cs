// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1, count = 0;            

while (count<N)
{
    if (N%2==0)
    {
        if (i%2==0)
        {
            Console.Write(i+ " ");
            i+=2;
            count+=2;
        }
        else
        {
            i++;
            count++;
        }
    }
    else
    {
        N-=1;
        count++;
        i++;
    }
}