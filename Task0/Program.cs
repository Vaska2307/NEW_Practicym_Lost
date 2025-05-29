// Задача 0. Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).
// Например:  4 -> 16.  -3 -> 9.  -7 -> 49:
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} -> {sqr} ");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {sqr1} ");