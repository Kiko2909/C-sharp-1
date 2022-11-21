//  принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

int a =0;
while (a < 1 || a > 7)
{
    Console.WriteLine("Введите число, чтобы узнать является ли этот день выходным: ");
    a = Convert.ToInt32(Console.ReadLine());

    if (a < 0 || a < 8)
        {
            bool Day (int weekend)
                {
                  return weekend == 6 || weekend == 7;
                }
                    bool week = Day(a);
                    Console.WriteLine(week == true ? $"{a} --> да" : $"{a} --> нет");
        }
        
    else Console.WriteLine("Такого дня недели не существует.");
}