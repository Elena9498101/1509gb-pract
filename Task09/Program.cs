// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

int number = new Random().Next(10, 100);
Console.WriteLine($"слуайное число отрезка 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифва числа = {firstDigit}");
else Console.WriteLine($"наибольшая цифва числа = {secondDigit}");

if (firstDigit == secondDigit) Console.WriteLine("цифры равны");