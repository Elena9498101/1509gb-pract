﻿// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число из отрезка 100 - 1000 => {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
Console.WriteLine($"{firstDigit}{thirdDigit}");
