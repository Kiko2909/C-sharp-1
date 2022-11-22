// принимает число и выдаёт произведение

Console.Clear();

int a = 0;

while (a < 1)
{
Console.WriteLine("Введите положительное число: ");
a = Convert.ToInt32(Console.ReadLine());
if (a < 0) Console.WriteLine("Введено некорретное число.");
}

int Sum (int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++) sum = sum * i;
    return sum;
}
int result = Sum(a);
Console.WriteLine($"{a} --> {result}");
