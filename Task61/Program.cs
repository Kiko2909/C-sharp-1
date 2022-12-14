// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[] CreateArrayRndInt (int rows, int columns, int min, int max)
{
    int[] arr = new int[rows * columns];
    Random rnd = new Random();
    for (int i= 0; i < arr.Length; i++)
    {
        // while (arr[i - 1] < arr[i])
        // {
             arr[i] = rnd.Next(min, max + 1);
        //     arr[i] -= max - (arr.Length - 1);  //чтобы оставлять запас на следующие элементы массива от максимума 
        // }
    }
    Array.Sort(arr);
    return arr;
}

int[,] FillMatrix (int[] arr, int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    int index = 0;
    int repeat = 0;
    int count = 0;
    while(count < 2)
    {
        for (int j = repeat; j < columns; j++ ) //вправо
        {                                           // j = 3 repeat = 0 columns = 4
            matrix[repeat, j] = arr[index];      //0,3
            index++;
        }
        rows--; // rows = 4 -1 =3 . //rows = 2
        repeat++; // repeat = 1 .  // repeat = 2
        for (int i = repeat; i <= rows; i++) // вниз
        {                                              // i = 3   repeat = 1 rows = 3
            matrix[i, columns - 1] = arr[index];  //1, 4-1//2, 4-1//3,4-1
            index++;
        }
        columns--; //columns = 3 ///columns = 2
        for (int k = columns; k > 0; k -- ) //влево
        {                                           //k = 2  repeat =2  rows = 2
            matrix[rows+count, k-1+count] = arr[index];        //  ///2,1
            index++;
        }
        rows--; // rows = 1
         // repeat = 2
        if (index != arr.Length)
        {
            for(int l = rows; l > 0; l-- )//вверх
            {                                       // l = 1
                matrix[l, 0] = arr[index];    //2, 0 //1,0 
                index++;          
            }
        }
        count++;
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


void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int[] array = CreateArrayRndInt(4, 4, 1, 40);
int[,] array2D = FillMatrix(array, 4, 4);

PrintArray(array);
Console.WriteLine();
PrintMatrix(array2D);
Console.WriteLine();