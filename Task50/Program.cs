// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите индекс строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)           //(int i = 0; i < rows; i++)     (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        //(int j = 0; j < columns; j++)    (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void FindIndexMatrix(int[,] matrix)
{
    if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
  
        Console.WriteLine(matrix[m, n]);
           
    else

        Console.WriteLine("Такого числа в массиве нет");

}

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
FindIndexMatrix(array2D);






// bool CheckNumberInArray(int[] array, int num)
// {
//     bool result = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             result = true;
//             break;
//         }
//     }
//     return result;
// }
// int[] arr = CheckNumberInArray(3, 4, -10, 399);
// PrintArray(arr);
// Console.WriteLine("Введите число для проверки его наличия в массиве:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (CheckNumberInArray(arr, number)) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// string answer = CheckNumberInArray(arr, number) ? "Да" : "Нет";
// Console.WriteLine(answer);


