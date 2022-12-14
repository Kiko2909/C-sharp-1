// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumMatrix (int[,] matrix)
{
    int a;
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        a = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {       
            a += matrix[i, j]; 
        }
        arr[i] = a; 
    }

    return arr;
}

int MinSum (int[] arr)
{
    int min = arr[0];
    int b = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
            b = i;
        }
    }
    return b;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 2);
PrintMatrix(array2D);
Console.WriteLine();

int[] amount = SumMatrix(array2D);
int min = MinSum(amount);
Console.WriteLine($"Наименьшая сумма равна {amount[min]} в строке {min + 1}");

