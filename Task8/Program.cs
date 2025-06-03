//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5 -> 24, 8 -> 2 4 6 8.
using System;
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
Console.WriteLine();
int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k+=2;
}

