Console.Clear();

Console.WriteLine("Введите число, чтобы увидеть все чётные числа от 1 до N");
int a = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j <= a; j++ )
{
    if (j % 2 == 0 && j != 0) 
    {
        Console.Write($"{j} ");
    }
}