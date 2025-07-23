using System;
using static System.Console;

Clear();
Write("Введите трехзначное число N: ");
int N = int.Parse(ReadLine());
int T = new Random().Next(100, 1000);
int number = (N % 100) / 10;
int number2 = (T % 100) / 10;
WriteLine($"{N} -> {number}");
WriteLine($"{T} -> {number2}");
