using System;
using static System.Console;
Clear();
Write("Введите координату X: ");
int X = int.Parse(ReadLine());
Write("Введите координату Y: ");
int Y = int.Parse(ReadLine());
if (X > 0 && Y > 0)
{
    WriteLine($"X -> {X}, Y -> {Y} => 1 Четверть! ");
}
if (X < 0 && Y > 0)
{
    WriteLine($"X -> {X}, Y -> {Y} => 2 Четверть! ");
}
if (X < 0 && Y < 0)
{
    WriteLine($"X -> {X}, Y -> {Y} => 3 Четверть! ");
}
if (X > 0 && Y < 0)
{
    WriteLine($"X -> {X}, Y -> {Y} => 4 Четверть! ");
}

