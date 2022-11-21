// Принимает на вход число и показвает дату и день недели 2023 года

Console.Clear();

int a =0;

while (a < 1 || a > 365)
{
    Console.WriteLine("Введите число, чтобы узнать день 2023 года: ");
    a = Convert.ToInt32(Console.ReadLine());

    if (a < 0 || a < 366)
        {
                
        }
        
    else Console.WriteLine("Такого дня нет в 2023 году.");
}