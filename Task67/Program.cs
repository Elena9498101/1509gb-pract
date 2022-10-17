// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
//
// 453 - 12
// 45 - 9


Console.Write("введите число число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);
Console.WriteLine(sum);

int SumDigits(int num)
{
    int sum1 = num % 10;
    if (num > 0) sum1 += SumDigits(num / 10);
    return sum1;
}



