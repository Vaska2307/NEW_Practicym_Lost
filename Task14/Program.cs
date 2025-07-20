using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int a = 7;
int b = 23;
if ((number % a == 0) && (number % 23 == 0))
{
    Write($"{number} -> да");
}
else
{
    Write($"{number} -> нет");
}