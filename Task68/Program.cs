// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int number = -1, number2 = -1;
while (number < 0 || number2 < 0)
{
    Console.WriteLine("Введите первое число: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    if (number < 1 || number2 < 1) Console.WriteLine("Числа должны быть положительными.");
}

int Ackerman (int m, int n)
{
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    if (m == 0 && n > 0) return n + 1;
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return n + m;
}

Console.WriteLine($"m = {number}; n = {number2} -> A(m,n) = {Ackerman(number, number2)}");