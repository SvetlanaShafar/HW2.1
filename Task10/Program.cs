﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
    Console.WriteLine($"Вторая цифра: {a = (a / 10) % 10}");
else 
Console.WriteLine("Введите трехзначное число!");
