// // Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// int[,] ConvertArray (int[,] matrix)
// {
//     int[,] temp = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {         
//         temp[i, j] = matrix[j, i];
//         }
//     }
//     return temp;
// }

int[,] ReplaceRowsColumnsMatrix(int[,]matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[columns, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix2[j, i] = matrix[i, j];
        }
    }
    return matrix2;
}

int[,] array2D = CreateMatrixRndInt(4, 5, 2, 9);
PrintMatrix(array2D);
Console.WriteLine();
// if (array2D.GetLength(0)== array2D.GetLength(1))
// {
// int[,] arrayConvert = ConvertArray(array2D);
// PrintMatrix(arrayConvert);
// }
// else Console.WriteLine("Замена невозможна, так как количество строк и столбцов не совпадает.");
array2D = ReplaceRowsColumnsMatrix(array2D);
PrintMatrix(array2D);
