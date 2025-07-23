using System;
using static System.Console;
Clear();
Write("Напишите цифру которая соответствует дню недели: ");
int N = int.Parse(ReadLine());

if (N < 1 || N > 7)
{
    WriteLine($"{N} -> Неверно введени номер");
    return;
}
if (N < 6)  //if (N > 0 && N < 6)
{
    WriteLine($"{N} -> Нет");
    return;
}
else
{
    WriteLine($"{N} -> Да");
}

