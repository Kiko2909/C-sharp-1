// Программа выводит случайное трёхзначное число и удаляет вторую цифру этого числа
//897->87

Console.Clear();

int number = new Random().Next(100, 1000); //[x,y)

Console.WriteLine($"Случайное трёхзначное число --> {number}");

int Res (int num) // int num = number
{
int firstDigit = num / 100;
int thirdDigit = num % 10;

return firstDigit * 10 + thirdDigit;
}

int result = Res(number);
Console.WriteLine($"Итог --> {result}");