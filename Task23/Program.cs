// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void CubTabl(int num)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"| {counter,2} | {counter * counter * counter,5} |");
        counter++;

    }

}
if (num > 0) CubTabl(num);
else Console.WriteLine("введено некорректное число");
