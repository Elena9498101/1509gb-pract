﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


//Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// вывод результата

int[] CreateArrayRndIntTrio(int size, int min, int max)

{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] GetSumEvenNum(int[] array)
{
    int sumEvenNum = default;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sumEvenNum++;
    }

    return new int[] { sumEvenNum };
}
int[] arr = CreateArrayRndIntTrio(899, 100, 999);
PrintArray(arr);
int[] getSumEvenNum = GetSumEvenNum(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumEvenNum[0]}");

