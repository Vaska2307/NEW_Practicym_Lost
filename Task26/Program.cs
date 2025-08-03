using System;
using static System.Console;
Clear();

Write("Введитк число N: ");
//int N = int.Parse(ReadLine());
//int result = GetNumbers(N);
WriteLine($"Колличество цифр в числе = {GetNumbers(int.Parse(ReadLine()))}");// сократили колличество переменных и строк и памяти занимаемой кодом

int GetNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {

        number = number / 10;
        count++;
    }
    return count;
}

