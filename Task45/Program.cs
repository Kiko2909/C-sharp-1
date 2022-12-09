// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x(k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.Clear();

Console.WriteLine("Введите переменную b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double Ox (double b, double bb, double k, double kk)
{
    double x = (bb - b) / (k - kk);
    return x;
}

double Oy (double b, double bb, double k, double kk, double x)
{
    double y = k * x + b;
    return y;
}

double FirstC = Ox(b1, b2, k1, k2);
double SecondC = Oy(b1, b2, k1, k2, FirstC);
Console.WriteLine($"Точка пересечения прямых --> ({FirstC}; {SecondC})");