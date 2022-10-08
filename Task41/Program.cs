﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3




int[] CreateArrayPolso(int size, int min, int max)

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

    int[] SumPositiveNum(int[] array)
{
    int sumPosNum = default;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPosNum++;
    }

    return new int[] { sumPosNum };
}

int[] arr = CreateArrayPolso(10, -2, 7);
PrintArray(arr);
int[] sumPositiveNum = SumPositiveNum(arr);
PrintArray(sumPositiveNum);
//Console.WriteLine($"количество положительных элементов = {sumPositiveNum}");



