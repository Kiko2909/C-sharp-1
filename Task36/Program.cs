//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        sum += 1;
    }
    return sum ;
}

int[] array = CreateArrayRndInt(25, 100, 999);
PrintArray(array);
int col = Number(array);
Console.WriteLine($"Количество чётных элементов в массиве --> {col}");