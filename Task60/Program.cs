// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt (int rows, int columns,int depth, int min, int max)
{
    int [,,] matrix = new int[rows, columns, depth];  // наш трёхмерный массив
    int[] array = new int [rows * columns * depth];  // пришлось переписать в одномерный, тк иначе числа повторялись
    Random rnd = new Random();
    int arri = 0; // индексация одномерного массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int temp = 0; 
                bool x = false;
                while (x == false)
                {
                    temp = rnd.Next(min, max + 1); // генерируем число
                    x = Format(array, temp);      // проверяем есть ли такое же
                }
                matrix[i, j, k] = temp;   // записываем это число в втрёхмерный массив
                array[arri++] = temp;    // и в одномерный, увеличивая его индекс
            }
        }
    }
    return matrix;
}
bool Format (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return false;
    }
    return true;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k > 0) Console.ForegroundColor = ConsoleColor.Blue; // для визуального удобства
                Console.Write($"{matrix[i,j,k], 4}({i}, {j}, {k}) ");
                Console.ResetColor();
            }
        }
        Console.WriteLine("");
    }
}

int a = 10, b = 10, c = 10;

while (a * b * c > 90 || a * b * c < 1)     //проверяем можно ли создать массив с такими параметрами
{
Console.WriteLine("Введите кол-во строк массива: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов массива: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину массива: ");
c = Convert.ToInt32(Console.ReadLine());

if (a < 1 || b < 1 || c < 1 ) 
Console.WriteLine("Введены некорректные значения.\n");
if ( a * b * c > 90) 
Console.WriteLine("С такими параметрами не останется уникальных чисел ):\nПожалуйста, введите иные значения.\n");
}

int[,,] array3D = CreateMatrixRndInt(a, b, c, 10, 99);  // оптимальные параметрыы 5 3 6
PrintMatrix(array3D);
Console.WriteLine();