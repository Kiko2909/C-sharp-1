// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[] CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int[size];
    Random rnd = new Random();
    for (int i= 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int Number (int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum ;
}

int[] array = CreateArrayRndInt(10, -5, 9);
PrintArray(array);
int col = Number(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях --> {col}");