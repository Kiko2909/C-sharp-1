// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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

int[,] array2D = CreateMatrixRndInt(6, 7, 2, 9);
PrintMatrix(array2D);
Console.WriteLine();

int row = -1;
int column = -1;

while (row < 0 || row > 6 || column < 0 || column > 7)
{
Console.Write("Введите строку массива (всего 6 строк): ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец массива (всего 7 столбцов): ");
column = Convert.ToInt32(Console.ReadLine());
if (row < 0 || column < 0) Console.WriteLine("Не может быть введено отрицательное значение.");
if (row > 6 || column > 7) Console.WriteLine("Такого элемента в массиве нет.");
}

Console.WriteLine($"{row}, {column} --> {array2D[row, column]}");