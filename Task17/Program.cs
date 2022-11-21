// принимает координаты х и у которые не равны 0 и выдаёт номер четверти плоскости в которой находится точка

Console.Clear();

Console.WriteLine("Введите координаты точек: ");
Console.Write("X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0 ) return 1;
    if (xc < 0 && yc > 0 ) return 2;
    if (xc < 0 && yc < 0 ) return 3;
    if (xc > 0 && yc < 0 ) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"Указанные координаты соответсвуют {quarter} четверти." 
: $"Введены некорректные координаты. ";
Console.WriteLine($"{result}");