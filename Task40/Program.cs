// принимает на вход два числа и проверяет может ли существовать такой треугольник
//каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();

int a = 0, b = 0, c = 0;

while (a < 1 || b < 1 || c < 1)
{
Console.WriteLine("Введите длины сторон треугольника: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
}

bool Triangle(int first, int second, int third)
{
    return first < second + third && second < first + third && third < first + second;
}

Console.WriteLine (Triangle(a, b, c) ? "Треугольник может существовать" : "Треугольник не может существовать");