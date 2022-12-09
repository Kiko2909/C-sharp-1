// программа которая будет создавать копию заданного массива с помощью поэлементарного копирования

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

int[]CopeArray (int[] arr)
{
    int[] newArr = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(4, 0, 30);
Console.WriteLine($"Исходный массив:");
PrintArray(array);
int[] copy = CopeArray(array);
Console.WriteLine($"Копия массива:");
PrintArray(copy);

