// напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое квадратом второго
// a=25 b=5 да
// a=2 b=10 нет
// a=9 b=3 да
// a=-3 b=9 нет

Console.WriteLine("введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
// int square=Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;

if (number1 == square)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет"); 
}