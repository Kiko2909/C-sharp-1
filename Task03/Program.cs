Console.Clear();

int a = 0;

while ( a < 100 || a > 999 )
{
Console.Write("Введите трёхзначное число, чтобы узнать его последнюю цифру: ");
a = Convert.ToInt32(Console.ReadLine());

if ( a > 99 && a < 1000)
{
    int last = a % 10;
    Console.WriteLine($"Последняя цифра: { last }");
}
else Console.WriteLine("Некорректное значение.");

}

