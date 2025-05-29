// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2 3, 4"
using System;
Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
//int i = n * (-1);
int i = -n; // интересное решение по смене знака
Console.Write($"{n} ->  ");
while (i <= n)
{
    Console.Write($"{i}, ");
    i++;
}