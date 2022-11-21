// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да

Console.Clear();

int number = 0;

while (number < 10000 || number > 99999)
{
    Console.WriteLine("Введите пятизначное число, чтобы узнать, является ли оно палиндромом: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number *= -1;
    if (number < 10000 || number > 99999) Console.WriteLine("Вы ввели не пятизначное число");
}

void Palindrome (int num)
{
    int mun = (num % 10 * 10000 + num / 10 % 10 * 1000 + num / 100 % 10 * 100 + num / 1000 % 10 * 10 + num /10000);
    Console.WriteLine(num == mun ? "Да" : "Нет");
}
Palindrome(number);