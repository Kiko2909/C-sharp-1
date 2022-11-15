Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b) 
{
    max = b;
        if (max < c)
        {
        max = c;
        }
}
else if (max < c) 
{
    max = c;
}
Console.WriteLine($"Max = {max}");
