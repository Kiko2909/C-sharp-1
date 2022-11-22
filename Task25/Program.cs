// принимает на вход число и выдаёт кол-во цифр в числе

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0) a *= -1;

int Count(int number)
{
    int length = 0;
    while(number > 0)
    {
        number = number / 10;
        length = length + 1;
    }
    return length == 0 ? 1 : length;
}
int result = Count (a);
Console.WriteLine($"{result}");