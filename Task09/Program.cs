/* Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа. */

Console.Clear();

int number = new Random().Next(10, 100); //[x,y)

Console.WriteLine($"Случайное число из отрезка --> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа -->{firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");
}
/*TEST*/