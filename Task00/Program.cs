// напишите программу, которая 
// на вход принимает число и выдает его квадрат
// (число умноженное на самого себя)
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"квадрат числа {number} = {square}");
// string str = Console.ReadLine()