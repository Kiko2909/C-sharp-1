// принимает на вход ЛЮБОЕ число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да

Console.Clear();

int number = 0;

while (number > - 11 && number < 11)
{
    Console.WriteLine("Введите число, чтобы узнать, является ли оно палиндромом: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number *= -1;
    if (number < 11) Console.WriteLine("Вы ввели некорректное число.");
}

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

void Palindrome (int num)
{
    int size = Count(num);
    int mun = 0;
    double Sum = 0;
    int num2 = num;
    for (int i = 1; i <= size; i++)
    {
        mun = num2 % 10;
        num2 = num2 / 10;
        int degree = size - i;
        Sum = Sum + mun * Math.Pow(10, degree);
    }
    //int mun = (num % 10 * 10000 + num / 10 % 10 * 1000 + num / 100 % 10 * 100 + num / 1000 % 10 * 10 + num /10000);
    Console.WriteLine(num == Sum ? "Да" : "Нет");
}
Palindrome(number);