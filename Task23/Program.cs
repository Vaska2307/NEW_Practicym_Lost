using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());
//int i = 1;
//double d = 0;
Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
    //d = Math.Pow(i, 3);
    Write($"{Math.Pow(i, 3)}, ");
    //i = i + 1;
}
