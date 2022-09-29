// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];

NumArray(array);
PrintArray(array);

void NumArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 99);
        
    }
    
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

