// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int exp = Convert.ToInt32(Console.ReadLine());
int counter = 1;


int Degree(int number, int exp)
{    
    int rezult = 1;
    while (counter <= exp)
    {
        rezult = rezult * number;
        counter++;
    }
    return rezult;
}

int rezult = Degree(number, exp);
Console.WriteLine($"{rezult}");
if(exp<=0) Degree(number, exp);
Console.WriteLine("введено некорректное второе число");
