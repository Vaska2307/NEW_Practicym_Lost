//Напишите программу, на вход прнимает число и выдает, является ли число четным (делиться ли оно на два без остатка).
// 4 -> да, -3 -> нет, 7 -> нет.
using System;
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N % 2 == 0)
{
    Console.WriteLine($"{N} -> Да");
}
else
{
    Console.WriteLine($"{N} -> Нет");
}

