// Задача 65. Задайте значение N. Напишите программу, которая
// выводит все натуральные числа в промежутке от M до N
// M=1 N=5 - > 1,2,3,4,5
// M=4 N=8 - > 4,6,7,8

Console.Write("введите число число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbersFromMToN(numberM, numberN);

void NaturalNumbersFromMToN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMToN(numM + 1, numN);
        
    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMToN(numM - 1, numN);
    }
    if (numM == numN)
    {
        Console.Write($"{numM} ");
    }
}