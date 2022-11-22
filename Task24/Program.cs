// принимает А и выдаёт сумму чисел от 1 до А

Console.Clear();

int a = 0;

while (a < 1)
{
Console.WriteLine("Введите положительное число: ");
a = Convert.ToInt32(Console.ReadLine());
if (a < 0) Console.WriteLine("Введено некорретное число.");
}

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) sum = sum + i;
    return sum;
}
int result = Sum(a);
Console.WriteLine($"{a} --> {result}");