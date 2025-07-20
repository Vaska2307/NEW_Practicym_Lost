using System;
using static System.Console;
Clear();
WriteLine("Введите первое число:");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine());
if (a % b == 0)
{
    WriteLine($"{a} кратно {b}");
}
else
{
    WriteLine($"{a} не кратно {b}, остаток {a % b}");
}
