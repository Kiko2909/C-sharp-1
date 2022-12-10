// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("]");
    }
}

double[] AverageMatrix (int[,] matrix)
{
    double[] avg = new double[matrix.GetLength(1)];
    double a;

    for (int i = 0; i < avg.Length; i++)
    {
        a = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            a += matrix[j, i];
        }
        avg[i] = Math.Round(a / matrix.GetLength(0), 3);
    }

    return avg;
}

void PrintArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(" | ");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

double[] array = AverageMatrix(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(array);
Console.WriteLine();