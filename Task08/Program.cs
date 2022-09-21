// напишите программу, которая на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= num)
{
    Console.Write($"{count}  ");
    count = count + 2;

}

