// по заданному номеру четверти показывает диапазон данных
Console.Clear();

Console.WriteLine("Введите номер четверти: ");
string x = Console.ReadLine();


string Quarter(string xc)
{
    if (xc == "1" ) return "x > 0 и y > 0";
    if (xc == "2" ) return "x < 0 и y > 0";
    if (xc == "3" ) return "x < 0 и y < 0";
    if (xc == "4" ) return "x > 0 и y < 0";
    return "Введены некорректные данные.";
}

string result = Quarter(x);
Console.WriteLine($"{result}");