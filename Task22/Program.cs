// напишите программу, которая принимает
// на вход число (N) и
// выдает таблицу квадратов чисел от 1 до N
// 5 - 1, 4, 9, 16, 25
// 2 - 1, 4

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void SqrTabl(int num)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"{counter, 3} {counter * counter, 5}");
        counter++;

    }
    
}
if(num>0) SqrTabl(num);
else Console.WriteLine("введено некорректное число");

