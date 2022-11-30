// Задать массив. Написать программу, которая определяет есть ли число в массива
// 4; [-9, 5, 7, 88] --> нет
// 3; [4, 68,-63, 0, 3, 5] --> да

Console.Clear();

int[] CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int[size];
    Random rnd = new Random();
    for (int i= 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

bool Number (int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false ;
}

int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);

Console.WriteLine("Введите число, чтобы узнать, есть ли оно в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());

bool num = Number(array, a);
Console.WriteLine(num == true ? "Да" : "Нет");

