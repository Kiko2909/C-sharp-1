// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Матрицу А можно умножить на матрицу В если
// число столбцов матрицы А равно числу строк матрицы В 

// Умножение матриц осуществляется путем умножения строки на столбец. 
// Находятся произведения первого элемента строки и первого элемента столбца, 
// второго элемента строки и второго элемента столбца и т.д. 
// Затем полученные произведения суммируются.


// В условии внутреннего цикла (со счётчиком k) 
// нужно брать количество столбцов первой матрицы, а не результирующей. И +1 тогда не нужен.

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

int[,] CreateMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int sum;
    int[,] thirdMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < thirdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdMatrix.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++) 
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            thirdMatrix[i,j] = sum;
        }
    }
    return thirdMatrix;
}

int aFirst = 0, bFirst = 0, aSecond = 1, bSecond = 1;

while (bFirst != aSecond)
{
Console.WriteLine("Введите кол-во строк первой матрицы: ");
aFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
bFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк второй матрицы: ");
aSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
bSecond = Convert.ToInt32(Console.ReadLine());
if(bFirst != aSecond) Console.WriteLine("Матрицу А можно умножить на матрицу В, только если \nчисло столбцов матрицы А равно числу строк матрицы В.\n");
}


Console.WriteLine("\nМатрица 1\n");
int[,] matrixA = CreateMatrixRndInt(aFirst, bFirst, 1, 9);
PrintMatrix(matrixA);
Console.WriteLine("\nМатрица2\n");
int[,] matrixB = CreateMatrixRndInt(aSecond, bSecond, 1, 9);
PrintMatrix(matrixB);
Console.WriteLine("\nРезультат перемножения матриц\n");
int[,] matrixC = CreateMatrixMultiplication(matrixA, matrixB);
PrintMatrix(matrixC);


//TODO: работает если кол-во столбцов А равно кол-ву строк В и        4 6 6 4
//  строк А больше столбцов В                                         9 3 3 2

// работает если все 4 параметра равны                             3 3 3 3
// работает если строк А меньше столбцов В                         4 5 5 6
//ели крайние значения болше средних                                  9 4 4 9