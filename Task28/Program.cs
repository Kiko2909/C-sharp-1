// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();

Console.WriteLine("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = 0;

while(b < 1)
{
    Console.WriteLine("Введите натуральную степень B: ");
    b = Convert.ToInt32(Console.ReadLine());
    if (b < 1) Console.WriteLine("Нужно ввести Натуральное число. ");
}

double Degree (double digit, double level)
{
   // int deg = 1;
   // for (int i = 1; i <= level; i++) deg = deg * digit;
    double deg = Math.Pow(digit, level);
    return deg;
}

double result = Degree(a, b);
Console.WriteLine($"{a} в степени {b} --> {result}");
