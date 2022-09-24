// напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

Console.WriteLine("введите х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите х2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2)
{
double result=(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
return result;
}
double res = Math.Round(Distance(x1,y1,x2,y2),2,MidpointRounding.ToZero);
Console.WriteLine(res);