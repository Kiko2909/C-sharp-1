// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84


Console.Clear(); 

Console.WriteLine("Введите значения первой точки:");
Console.Write("x = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения второй точки:");
Console.Write("x = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(double Xa, double Ya, double Xb, double Yb, double Za, double Zb)
{
    double Sq = (Xa - Xb)*(Xa - Xb) + (Ya - Yb)*(Ya - Yb) + (Za - Zb)*(Za - Zb);
    double Cc = Math.Sqrt(Sq);
    double Round = Math.Round(Cc, 2, MidpointRounding.ToZero);
    return Round;
}

double result = Distance(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Расстояние между точками равно --> {result}");