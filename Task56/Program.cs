//Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

void DeleteRowColumnMinElementMatrix(int[,] matrix, int row, int column)
{
    int rows =  matrix.GetLength(0);                           
    int columns = matrix.GetLength(1);                            
    int[,] matrix2 = new int[rows - 1, columns - 1];  
    int x = 0; // счётчик строк для нового массива
    for (int i = 0; i < rows; i++)     
    {
        int y = 0; // счётчик столбцов для нового массива
        for (int j = 0; j < columns; j++)
        {
            if ( i == row || j == column);
            else 
            {
                matrix2[x, y]= matrix[i, j];
                y++;
            }
        }   
        if (i != row) x++;  
    } 
    PrintMatrix(matrix2);
    Console.WriteLine();
}

void FindMinimum (int[,] matrix)
{
    int a = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ( matrix[i,j] < a) a = matrix[i, j]; // находим минимум
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ( matrix[i, j] == a)                 // находим индексы минимума
            {
                DeleteRowColumnMinElementMatrix(matrix, i, j); //обращаемся к методу
                i += matrix.GetLength(0);   // выходим из цикла
                j += matrix.GetLength(1);   // увеличиваем до предельного значения
            }
        }
    }
}



int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
FindMinimum (array2D);
