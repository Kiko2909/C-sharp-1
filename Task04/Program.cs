Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0)
{
for (int b = a; b <= (a * -1) ; b++)
{
   Console.Write($"{b} ");
}
}

else 
{
for (int b = (a * -1); b <= a ; b++)
{
   Console.Write($"{b} ");
}
}
