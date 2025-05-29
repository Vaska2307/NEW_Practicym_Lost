//Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Например: 3 -> Среда;   5 ->  Пятница;
using System;

Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine($"Неверно указан номер недели {number} ");
}
if (number == 1)
{
    Console.WriteLine($"{number} -> Понедельник");
}
if (number == 2)
{
    Console.WriteLine($"{number} -> Вторник");
}
if (number == 3)
{
    Console.WriteLine($"{number} -> Среда");
}
if (number == 4)
{
    Console.WriteLine($"{number} -> Четверг");
}
if (number == 5)
{
    Console.WriteLine($"{number} -> Пятница");
}
if (number == 6)
{
    Console.WriteLine($"{number} -> Суббота");
}
if (number == 7)
{
    Console.WriteLine($"{number} -> Воскресенье");
}
