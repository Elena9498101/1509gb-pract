// напишите программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат точек в этой четверти (X.Y)

Console.WriteLine("ввдите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("ввдите координаты точки ");
// Console.Write("x ");
// int xC = Convert.ToInt32(Console.ReadLine());
// Console.Write("y ");
// int yC = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xC, yC);
// Console.WriteLine(quarter == 0 ? "введены не корректные координаты" : quarter);

// void Diapason(int quarter1)
// {
//     if (quarter1 == 1) Console.WriteLine("x > 0,  y > 0");
//     else if (quarter1 == 2) Console.WriteLine("x < 0  y > 0");
//     else if (quarter1 == 3) Console.WriteLine("x < 0  y < 0");
//     else if (quarter == 4) Console.WriteLine("x > 0  y < 0");
//     else Console.WriteLine("введены не корректные данные");
// }

// Diapason(quarter);


string rez = Quarter(quarter);
Console.WriteLine(rez);

string Quarter(int quarter1)

{
    if (quarter1 == 1) return "x > 0,  y > 0";
    if (quarter1 == 2) return "x < 0  y > 0";
    if (quarter1 == 3) return "x < 0  y < 0";
    if (quarter1 == 4) return "x > 0  y < 0";
    return ("введено не корректное число");
}