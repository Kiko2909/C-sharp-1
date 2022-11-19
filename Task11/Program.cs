Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

/*
bool Multiplycity(int num1 , int num2)
{
    return (num1 % num2 == 0);
    //if (num1 % num2 == 0) return true;
    //return false;
}

bool result = Multiplycity(a, b);
Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток --> {a % b}");
*/

int Multi(int num1, int num2)
{
    return num1 % num2;
}

int result = Multi(a , b);
Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток --> {result}");