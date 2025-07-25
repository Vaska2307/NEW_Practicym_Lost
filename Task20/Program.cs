using System;
using static System.Console;
Clear();
Write("Введите координату Х1 : ");
int X1 = int.Parse(ReadLine());
Write("Введите координату Y1 : ");
int Y1 = int.Parse(ReadLine());
Write("Введите координату Х2 : ");
int X2 = int.Parse(ReadLine());
Write("Введите координату Y2 : ");
int Y2 = int.Parse(ReadLine());
double d = Math.Sqrt((Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));
WriteLine($"Длинна отрезка A({X1},{Y1}) ; B({X2},{Y2}) -> {d:f3} ");

