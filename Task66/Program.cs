// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int sum = SumNaturalNumbersFromMToN(numberM, numberN);
Console.Write(sum);

int SumNaturalNumbersFromMToN(int numM, int numN)
{
    if (numN < numM) return 0;
    int sum = SumNaturalNumbersFromMToN(numM, numN - 1);
    return sum += numN;
}
