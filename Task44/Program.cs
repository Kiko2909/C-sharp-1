// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();

int[] Array()
{
    int a = 0;
    Console.Write("Введите количество чисел: ");
    int digits = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[digits];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число:");
        a = Convert.ToInt32(Console.ReadLine());
        arr[i] = a;
    }
    return arr;
}

int Positive(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += 1;
    }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] array = Array();
int result = Positive(array);
PrintArray(array);
Console.WriteLine($"Количество положительных чисел среди введённых --> {result}");