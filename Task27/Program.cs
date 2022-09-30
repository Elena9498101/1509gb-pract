//Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;


int SummaNum(int number, int sum)
{
    number = number / 10;
    while (number > 0)
    {

        sum = sum + number % 10;
    }
    return sum;

}
int rez = SummaNum(number, sum);
Console.WriteLine(rez);
