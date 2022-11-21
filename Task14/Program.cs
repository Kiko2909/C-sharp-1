Console.Clear();

int a = 0;

while ( a < 100 || a > 999 )
{
Console.Write("Введите трёхзначное число, чтобы узнать его вторую цифру: ");
a = Convert.ToInt32(Console.ReadLine());

if (a < 0) a = a * -1;

Console.WriteLine(a < 100 || a > 999 ? "Некорректное значение." : "");
}

int Number(int number)
{
    return number / 10 % 10;
}
int second = Number(a);
Console.WriteLine($"Вторая цифра: { second }");