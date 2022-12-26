// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении обойтись использованием массивов.

Console.Clear();

string[] array = new string [4]{"3", "defc", ":}!", "papaya"};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] ArrRes (string[] arr)
{
    int size = 0, index = 0;

    for (int j = 0; j < arr.Length; j++) 
        if (arr[j].Length <= 3) size++;

    string[] newArr = new string [size];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    return newArr;
}

PrintArray(array);
string[] result = ArrRes(array);
PrintArray(result);
