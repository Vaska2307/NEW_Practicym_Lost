// Задача 2. Напишите программу, которая на вход принемает два числа и выдает, какое число большее, а какое меньшее.
// Например: a = 25, b = 5 -> a больше b, a = 2, b = 10 -> a меньше b, a = 9, b = 9 -> a равно b.
using System;
Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write($"{a} больше {b}");
}
else
{
    if (a < b)
    {
        Console.Write($"{a} меньше {b}");
    }
    else
    {
        Console.Write($"{a} равно {b}");
    }
}