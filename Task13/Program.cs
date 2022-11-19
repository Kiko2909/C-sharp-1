// принимает два числа и проверяет, является ли одно число квадратом другого

Console.Clear();

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(a, b) ? "Да" : "Нет");

bool Square (int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

// bool result = Square(a, b);
// Console.WriteLine(result ? "Да" : "Нет" );