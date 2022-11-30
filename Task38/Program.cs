// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateRndDouble (int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i= 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}

double Max (double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double Min (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double Subtraction (double max, double min)
{
    return Math.Round(max - min, 1);
}

double[] array = CreateRndDouble(5, 0, 9);
PrintArray(array);
double result = Subtraction(Max(array),Min(array));
Console.WriteLine($"Разница максимально и минимального значений равны --> {result}");


/*
double Max (double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double result = Max (array);
Console.WriteLine($"Разница максимально и минимального значений равны --> {result}");
*/