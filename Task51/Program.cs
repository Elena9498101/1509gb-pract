// //Задача 51. Задаайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// с индексами (0,0)  (1,1)  и т.д.
// 1 4 7 2           
// 5 9 2 3           
// 8 4 2 4           
// сумма = 1+9+2=12

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

int CreateSumElemDiag(int[,] matrix)
{

    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];      
        }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(5, 3, -10, 10);
PrintMatrix(array2D);
int sumDiag=CreateSumElemDiag(array2D);
Console.WriteLine("сумма элементов, находящихся на главной диагонали = " + sumDiag);