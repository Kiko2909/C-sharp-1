//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int [] array = new int[8];

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,100);
    }
}

void PrintArray(int[] col)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
}

Console.Write("[ ");

FillArray(array);
PrintArray(array);

Console.Write("]");
Console.WriteLine();




/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100); 
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int [] array = new int [8];
Console.Write("[ ");
FillArray(array);
PrintArray(array);
Console.Write("]");
Console.WriteLine();
*/