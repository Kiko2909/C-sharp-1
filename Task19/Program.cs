// принимает координаты двух точек и находит расстояние между ними в 2D пространстве
//А(3,6) В(2,1) -- 5,09
//Xa-Xb квадрат+ Ya-Yb квадрат = корень
/*
квадратный корень
int n = 1234;
double res = Math.Sqrt(n);

округление
double n1 = 5.0998;
double nRound = Math.Round(n1, 2, MidpointRounding.ToZero);
*/

Console.Clear(); 

Console.WriteLine("Введите значения первой точки:");
Console.Write("x = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения второй точки:");
Console.Write("x = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(double Xa, double Ya, double Xb, double Yb)
{
    double Sq = (Xa - Xb)*(Xa - Xb) + (Ya - Yb)*(Ya - Yb);
    double Cc = Math.Sqrt(Sq);
    double Round = Math.Round(Cc, 2, MidpointRounding.ToZero);
    return Round;
}

double result = Distance(xa, ya, xb, yb);
Console.WriteLine($"{result}");