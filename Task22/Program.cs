using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int i = 1;
//double sqr = 0;
while (i <= N)
{
    //sqr = Math.Pow(i, 2);
    Write($"{Math.Pow(i, 2)}, ");
    //WriteLine($"{i * i}");
    i = i + 1;
}
