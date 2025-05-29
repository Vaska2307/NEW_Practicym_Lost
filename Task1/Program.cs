//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Например: a = 25, b = 5 -> да; a = 2, b = 10 -> нет;
using System;
Console.Clear();
Console.WriteLine("Введите первое число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int b = int.Parse(Console.ReadLine());

//int number = b * b;
//int number = Convert.ToInt32(Math.Pow(b, 2));

//if (a == number)
if(b * b == a) // Интересное решение
{
    Console.WriteLine($"{a}, {b} -> да");
}
else
{
    Console.WriteLine($"{a}, {b} -> нет");
}