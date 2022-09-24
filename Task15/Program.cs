//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string rez = Weak(number);
Console.WriteLine(rez);

string Weak(int num)
{

    if (num == 1) return "понедельник";
    if (num == 2) return "вторник";
    if (num == 3) return "среда";
    if (num == 4) return "четверг";
    if (num == 5) return "пятница";
    if (num == 6) return "суббота";
    if (num == 7) return "воскресенье";
    return "введите корректное число";
}

Console.WriteLine(number == 6 || number == 7 ? "выходной" : "нет");






