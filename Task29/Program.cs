// Принимает число и выдаёт сумму цифр в числе

Console.Clear();

Console.WriteLine("Введите число, чтобы узнать, сумму цифр в нём: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

int Count(int digit)
{
    int length = 0;
    while(digit > 0)
    {
        digit = digit / 10;
        length = length + 1;
    }
    return length == 0 ? 1 : length;
}

int Sum(int num)
{
    int size = Count(num);
    int mun = 0;
    double Sum = 0;
    for (int i = 1; i <= size; i++)
    {
        mun = num % 10;
        num = num / 10;
        Sum = Sum + mun;
    }
}
int res = Sum (number);
Console.WriteLine($"Сумма цифр числа равна --> {res}");

//Вопрос. Можно ли сделать так?
/*
void Sum(int num)
{
    int size = Count(num);
    int mun = 0;
    double Sum = 0;
    for (int i = 1; i <= size; i++)
    {
        mun = num % 10;
        num = num / 10;
        Sum = Sum + mun;
    }
    Console.WriteLine($"Сумма цифр числа равна --> {Sum}");
}
Sum (number);
*/