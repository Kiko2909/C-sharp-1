// преобразовывает десятичное число в двоичное
//45 - 101101
// 3 - 11
// 2 - 10

Console.Clear();

/*
string Binary(int numb)
{
    string bin = string.Empty;
    while (numb > 0)
    {
        bin = numb % 2 + bin;
        numb /=2;
    }
    return bin;
}
*/

int[] Binary (int numb)
{
    int numb1 = numb;
    int digits = 0;

    while (numb1 > 0)
    {
        numb1 /= 2;
        digits ++;
    }

    int[] bin = new int [digits];

    for (int i = 0; i < bin.Length; i++)
    {
        bin [bin.Length - i - 1] = numb % 2;
        numb /= 2;
    }
    return bin;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(a);
PrintArray(binary);
Console.WriteLine();