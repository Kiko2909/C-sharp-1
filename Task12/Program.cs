// Принимаем на вход число, проверяем красно ли оно одновременно и 7 и 23

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multi(a) ? "Да" : "Нет");

bool Multi(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

// bool result = Multi(a);
// Console.WriteLine (result ? $"Число {a} кратно 7 и 23" : "Не кратно 7 и 23");