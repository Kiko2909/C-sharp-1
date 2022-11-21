// принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Table (int n)
{        
    int x = 1;
    for(int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{x} --> {x*x}"); 
        x+=1;
    }
    return 0;
}
Table(num);
