//задача 24. на входе число А
// на выходе сумма чисел от 1 до А
// 7 - 28
// 4 - 10
// 8 - 36

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int SumRes = SummaNum2(num);
Console.WriteLine($"сумма чисел от 1 до {num} = {SumRes}");

int SummaNum(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;

}



int SummaNum2(int num)
{
    int sum = default;
    int counter = 1;
    while (counter <= num)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}