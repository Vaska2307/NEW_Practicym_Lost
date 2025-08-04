using System;
using static System.Console;

Clear();
Write("Введите первое число A: ");
int A = int.Parse(ReadLine());
Write("Введите второе число B: ");
int B = int.Parse(ReadLine());
WriteLine($"Число {A} в степени {B} -> {GetDegree(A, B)} ");

int GetDegree(int num1, int num2)
{
    if (num2 == 0)
    {
        return 1;
    }
    int result = 1;
    int count = 1;
    while (count <= num2)
    {
        result = result * num1;
        count++;
    }
    return result;
}