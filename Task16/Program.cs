using System;
using static System.Console;
Clear();
Write("Введите первое число a: ");
int a = int.Parse(ReadLine());
Write("Введите второе число b: ");
int b = int.Parse(ReadLine());

if (a * a == b)
{
    Write($"{b} квадрат {a}");
}
else
{
    if (b * b == a)
    {
        Write($"{a} квадрат {b}");
    }
    else
    {
        WriteLine("Не является");
    } 
}
