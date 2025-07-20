using System;
using static System.Console;
Clear();
int number = new Random().Next(100, 1000);
int a = (number / 100) * 10;
int b = number % 10;
Write($"{number} -> {a + b} ");
