// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int num = 0;
while (num < 1)
{
    Console.WriteLine("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 1) Console.WriteLine("Введено некорректное значение.");
}

void Table (int n)
{        
    int x = 1;
    for(int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{x} | {x*x*x}"); 
        x+=1;
    }
}
Table(num);