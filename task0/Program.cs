﻿// Напишите программу, которая на входе прниимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// Math.Pow(number,2) - степень
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine());

if (numberOne == Math.Pow(numberTwo,2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

