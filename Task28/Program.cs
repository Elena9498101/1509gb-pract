// задача 28:
// на входе число N 
// на выходе произведение чисел от 1 до N 
// 4 - 24
// 5 - 120

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitMulty(int number)
{
    int multy=1;
    for (int i = 1; i <= number; i++)
    {
        multy=multy*i;
    }
    return multy;
    
}
if (number>0)
{
    int rez = DigitMulty(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {rez}");
}
else Console.WriteLine("введено некорректное значение ");


