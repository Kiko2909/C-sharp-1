/* Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа. */

Console.Clear();

int number = new Random().Next(10, 100); //[x,y)

Console.WriteLine($"Случайное число из отрезка --> {number}");

/* int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа -->{firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");
}
TEST*/

int MaxDigit (int num) // int num = number
{
int firstDigit = num / 10;
int secondDigit = num % 10;

// if (firstDigit > secondDigit) return firstDigit;
// return secondDigit;

// int max = firstDigit > secondDigit ? firstDigit : secondDigit;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");