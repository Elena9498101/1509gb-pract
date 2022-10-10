//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7   -2   -0,2
// 1  -3,3  8   -9,9
// 8   7,8 -7,1  9

Console.WriteLine("введите количество строк матрицы: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов матрицы: n");
int n = Convert.ToInt32(Console.ReadLine());


double[,] CreateMatrixIndex(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)           //(int i = 0; i < rows; i++)     
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        //(int j = 0; j < columns; j++)    
        {
            matrix[i, j] = rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            //else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

double[,] arrayInd = CreateMatrixIndex(m, n);
PrintMatrix(arrayInd);
