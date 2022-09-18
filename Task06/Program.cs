// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка)
// 4 - да
// -3 - нет
// 7  - нет


Console.WriteLine("введите первое число ");
double number1 = Convert.ToInt32(Console.ReadLine());

number1=number1%2;

if(number1==0) Console.WriteLine("да");
else
{
   Console.WriteLine("нет"); 
}

Console.WriteLine("введите второе число ");
double number2 = Convert.ToInt32(Console.ReadLine());

number2=number2%2;

if(number2==0) Console.WriteLine("да");
else
{
   Console.WriteLine("нет"); 
}

Console.WriteLine("введите третье число ");
double number3 = Convert.ToInt32(Console.ReadLine());

number3=number3%2;

if(number3==0) Console.WriteLine("да");
else
{
   Console.WriteLine("нет"); 
}

