using System;
using static System.Console;
Clear();
Write("Введите номер четверти: ");
int number = int.Parse(ReadLine());
switch (number)
{
    case 1:
    {
        WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0, y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0, y < 0");
        break;
    }
    default:
    {
        WriteLine("Неверно введени номер четверти! ");
        break;
    }
}

//if ((number > 4) || (number < 1))
//{
   // WriteLine($"Не верно введен номер четверти {number}");
   // return;
//}
//if (number == 1)
//{
   // WriteLine($"{number} -> X > 0; Y > 0");
//}
//if (number == 2)
//{
   // WriteLine($"{number} -> X < 0; Y > 0");
//}
//if (number == 3)
//{
   // WriteLine($"{number} -> X < 0; Y < 0");
//}
//if (number == 4)
//{
    //WriteLine($"{number} -> X > 0; Y < 0");
//}
