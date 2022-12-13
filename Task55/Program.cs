// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] TurnToArray (int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int a = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[a++]= matrix[i, j];
        }
    }
    return arr;
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];

    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            PrintMessage (num, count);
            count = 1;
            num = arr[i];
        }
    }
    PrintMessage (num, count);
}

void PrintMessage (int num, int count)
{
    Console.WriteLine($"Число {num} втречается {count} раз.");
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(" | ");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = TurnToArray(array2D);
Array.Sort(array);
PrintArray(array);
Console.WriteLine("\n");
CountValue(array);
