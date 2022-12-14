// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number, number2);

void NaturalNumbers (int num1, int num2)
{
    if (num2 == 0) return;
    if (num1 < num2)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num2 < num1)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    if (num2 == num1) Console.Write($"{num1} ");
}