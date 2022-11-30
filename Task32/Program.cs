// заменить отрицательные элементы массива на положительные и наоборот
// [-4, -6, 8, 9] --> [4, 6, -8, -9]

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

void TurnTo (int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);
TurnTo(array);
PrintArray(array);
