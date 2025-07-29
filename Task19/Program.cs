using System;
using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int number = int.Parse(ReadLine());
if (number < 10000 || number > 99999)
{
    WriteLine($"Введено неверное число {number}: ");
    return;
}
int k = number;
int a1 = number / 10000;
number = number - a1 * 10000;
int a2 = number / 1000;
number = number - a2 * 1000;
int a3 = number / 100;
number = number - a3 * 100;

int b1 = number % 10;
int b2 = number / 10;

if (a1 == b1 && a2 == b2)
{
    WriteLine($"Xисло {k} палиндром: ");
}
else
{
    WriteLine($"Xисло {k} не палиндром: ");
}