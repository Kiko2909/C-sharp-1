// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число, чтобы узнать его третью цифру: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0) a = a * -1;

bool Counter (int num)
{
    return num < 100;
}

int Digit(int number)
{
     while (number > 999) 
        {
            number = number / 10;
        }
    number = number % 10;

   return number;
}

bool fact = Counter(a);
int result = Digit(a);
Console.WriteLine(fact == true ? "Третьей цифры нет." : $"Третья цифра --> {result} ");










 /*switch(a)
   {
    case < 100:
        Console.WriteLine("Третьей цифры нет. ");
        break;
    default:
        while (a > 999) 
        {
            a = a / 10;
        }
        int third2 = a % 10;
        Console.WriteLine($"Третья цифра --> {third2} ");
        break;

   }*/