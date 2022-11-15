Console.Clear();

int a = 0;

/*while (a < 1 || a > 7)
{
Console.Write("Введите число от 1 до 7, чтобы узнать день недели: ");
a = Convert.ToInt32(Console.ReadLine());

if (a == 1) Console.WriteLine("Понедельник");
else if (a == 2) Console.WriteLine("Вторник");
else if (a == 3) Console.WriteLine("Среда");
else if (a == 4) Console.WriteLine("Четверг");
else if (a == 5) Console.WriteLine("Пятница");
else if (a == 6) Console.WriteLine("Суббота");
else if (a == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Некорректное значение");
}*/

while (a < 1 || a > 7)
{
Console.Write("Введите число от 1 до 7, чтобы узнать день недели: ");
a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;   
    case 3:
        Console.WriteLine("Среда");
        break;     
    case 4:
        Console.WriteLine("Четверг");
        break;  
    case 5:
        Console.WriteLine("Пятница");
        break;  
    case 6:
        Console.WriteLine("Суббота");
        break;   
    case 7:
        Console.WriteLine("Воскресенье");
        break;  
    default:
        Console.WriteLine("Некорректное значение");
        break;
}

}