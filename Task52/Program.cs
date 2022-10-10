// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)           //(int i = 0; i < rows; i++)     
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        //(int j = 0; j < columns; j++)    
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

void ArithmeticalMeanColumn(int[,] matrix)
{
    double arithmeticalMeanColumn = 0;
    double sumColumns = 0;

   
    for (int j = 0; j < matrix.GetLength(1); j++)           //(int i = 0; i < rows; i++)     
    {
        for (int i = 0; i < matrix.GetLength(0); i++)        //(int j = 0; j < columns; j++)    
        {
            sumColumns += matrix[i, j];
        }
        arithmeticalMeanColumn = sumColumns / matrix.GetLength(0);
        Console.Write($"Сумма {j + 1} столбца = {sumColumns} ");
        Console.WriteLine($" Среднеарифметическое = {arithmeticalMeanColumn}");
        sumColumns = 0;
    }
}

int[,] array2D = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(array2D);
ArithmeticalMeanColumn(array2D);