// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Degree (int num, int deg)
{
    return deg == 0 ? 1 : Degree(num, deg - 1) * num;
}
Console.WriteLine($"{number} в степени {number2} --> {Degree(number, number2)}");