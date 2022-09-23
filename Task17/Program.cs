// Напишите программу, которая принимает на вход
// координаты точки (X,Y), причем X !- 0 Y != 0 и выдает
// номер четверти плоскости, в которой находится эта точка

Console.WriteLine("ввдите координаты точки ");
Console.Write("x ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("y ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "введены не корректные координаты: " : quarter);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
string quarterStr = QuarterStr(xC, yC);
Console.WriteLine(quarterStr);

string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return "первая четверть";
    if (x < 0 && y > 0) return "вторая четверть";
    if (x < 0 && y < 0) return "третья четверть";
    if (x > 0 && y < 0) return "четвертая четверть";
    return "введены не корректные координаты";
}