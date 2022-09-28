//задача 26: на входе - число
// на выходе количество цифр в числе
// 456 - 3
// 78 - 2
// 89126 - 5

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int QuatityNum(int number)
{
    int counter = 0;
    while (number > 0)
    {
        number = number / 10;
        counter++;
    }
    return counter;
}
int rez = QuatityNum(Math.Abs(number));
Console.WriteLine(rez);
