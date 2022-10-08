//Задача 49. Задаайте двумерный массив.
// Найдите элементы, у которых оба индекса четные,
// замените эти элементы на их квадраты
// 1 4 7 2           1 4 49 2
// 5 9 2 3           5 9  2 3
// 8 4 2 4          64 4  4 4 

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

void CreateEvenSquarElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)          // i+=2  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)       // j+=2    
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];      // matrix[i, j] *= matrix[i, j];
        }
    }
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
int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);   //  в переменную помещаем массив, созданный в методе CreateMatrixRndInt
PrintMatrix(array2D);                                   // печатаем массив
Console.WriteLine();
CreateEvenSquarElem(array2D);                           // с помощю метода CreateEvenSquarElem в переменную записываем измененный массив
PrintMatrix(array2D);                                   // печатаем изененный массив


