// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int number = 0, number2 = 0;
while (number < 1 || number2 < 1)
{
    Console.WriteLine("Введите первое число: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    if (number < 1 || number2 < 1) Console.WriteLine("Числа должны быть положительными.");
}

int Sum (int num1, int num2)
{
    if (num1 < num2) return Sum(num1, num2 - 1) + num2;
    if (num2 < num1) return Sum(num1 - 1, num2) + num1;
    return num1;

}
Console.WriteLine($"M = {number}; N = {number2} -> {Sum(number, number2)}"); 