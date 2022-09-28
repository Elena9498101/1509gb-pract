// задача 30: напишите программу, которая 
// вводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке: 
// [1,0,1,1,0,1,0,0]



int[] array = new int[8];
// int[] ResArray = GetArray(array);
GetArray(array);
PrintArray(array);

// int[] GetArray(int[] array)
void GetArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = rnd.Next(0, 2);
    }
    // return array;
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

