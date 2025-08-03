using System;
using static System.Console;

Clear();
WriteLine("Введите число N: ");
int N = int.Parse(ReadLine());
int summa = GetSumNumber(N);
WriteLine(summa);

int GetSumNumber(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}