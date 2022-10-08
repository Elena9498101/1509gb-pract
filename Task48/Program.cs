// Задача 48. Задаайте двумерный массив размера m на n.
// каждый элемент в массиве находится по формуле Amn = m*n
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("введите количество строк матрицы: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов матрицы: n");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)           //(int i = 0; i < rows; i++)     
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        //(int j = 0; j < columns; j++)    
        {
            matrix[i, j] = i + j;
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
        Console.WriteLine("  ]");
    }
}

int[,] arrayInd = CreateMatrixSumIndex(m, n);
PrintMatrix(arrayInd);