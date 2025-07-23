using System;
using static System.Console;
Clear();
Write("Введите число n1: ");
int n1 = int.Parse(ReadLine());
if (n1 < 100 && n1 > -100)
{
    WriteLine($"{n1} -> нет третьей цифры ");
    return;
}
else
{
    int number1 = (n1 % 1000) / 100;
    WriteLine($"{n1} -> {number1}");
}

//int number1 = (n1 / 100) % 10;
//WriteLine($"{n1} -> {number1}");