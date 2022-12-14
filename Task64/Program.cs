// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

int Sum (int num)
{
    return num != 0 ? num % 10 + Sum(num / 10) : 0;
}
Console.WriteLine($"Сумма чисел --> {Sum(number)}"); 