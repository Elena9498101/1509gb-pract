// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// A(m,n)=n+1               if m=0
// A(m,n)=A(m-1,1)          if m>0 && n=0
// A(m,n)=A(m-1,A(m,n-1))   if m>0 && n>0
// m, n - не могут быть отрицательными

Console.WriteLine("введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
     else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
}


if (numM < 0 | numN < 0)
{
    Console.WriteLine("m, n - не могут быть отрицательными");
}
else
{
    int rez = FunctionAkkerman(numM, numN);
    Console.WriteLine(rez);
}
