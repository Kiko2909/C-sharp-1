// Массив из 12 элементов [-9,9]
//найти суммц отрицательных и положительных элементов массива

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

int SumMn (int[] arr)
{
    int minus = 0; 
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0 ) minus += arr[i];
    }
    return minus;
}

int SumPl (int[] arr)
{
    int plus = 0; 
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 ) plus += arr[i];
    }
    return plus;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int negative = SumMn(array);
int positive = SumPl(array);
Console.WriteLine($"Сумма отрицательных элементов равна --> {negative} \nСумма положительных элементов равна --> {positive}");

