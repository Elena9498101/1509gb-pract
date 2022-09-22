// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите число из интервала 100 - 999: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1;
int num2;

num1 = number / 10;
num2 = num1 % 10;
Console.WriteLine($"{num2}");







