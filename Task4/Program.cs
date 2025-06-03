// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2  3  7 -> 7, 45  5  78 -> 78, 22  3  9 -> 22.
using System;
Console.Clear();
Console.WriteLine("Введите первое число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число c: ");
int c = int.Parse(Console.ReadLine());
if ((a > b) && (a > c))
{
    Console.WriteLine($"max = {a} ");
}
else
{
    if ((b > a) && (b > c))
    {
        Console.WriteLine($"max = {b} ");
    }
    else
    {
        if (c > b)
        {
            Console.WriteLine($"max = {c} ");
        }
    }
}
// Второе решение:
int max = a;
if (max < b)
{
    max = b;
}
if (c > max)     // Это тоже вариант решения.
{
    max = c;
}
Console.WriteLine(max);
