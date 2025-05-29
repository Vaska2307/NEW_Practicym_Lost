// Задача 7. Напишите программу. которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6, 782 -> 2, 918 -> 8.
using System;
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int number = n % 10;
Console.Write($"{n} -> {number}");

