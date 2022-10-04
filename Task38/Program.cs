// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// Console.WriteLine(max1);

double[] CreateArrayRndInt(int size, double min, double max)

{
    double[] array = new double[size];
    var rnd = new Random();
    double diff = max - min;
    
    for (int i = 1; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (diff) + min, 2);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] DifferentMaxMin(double[] array)
{
    double max = default;
    double min = default;
    double diff = default;


    for (int i = 0; i < array.Length; i = i + 2)
    {
        if (array[i] > array[i + 1])
        {
            max = array[i]; min = array[i + 1];
        }

        else
        {
            max = array[i + 1]; min = array[i];
            i++;
        }

    }
    diff = max - min;
    return new double[] { diff };

    double diffMaxMin = diff;
}

double[] arr = CreateArrayRndInt(5, 1.1, 99.9);
PrintArray(arr);
double[] diffMaxMin = DifferentMaxMin(arr);
PrintArray(diffMaxMin);

