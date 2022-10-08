﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("для системы уравнений введите последовательно коэффициенты: b1, k1, b2, k2");
double b1 = Convert.ToUInt32(Console.ReadLine());
double k1 = Convert.ToUInt32(Console.ReadLine());
double b2 = Convert.ToUInt32(Console.ReadLine());
double k2 = Convert.ToUInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("координаты пересечения точки пересечения двух прямых, заданных уравнениями /y = k1 * x + b1, y = k2 * x + b2/ :" + (x, y));



