// Не используя рекурсию выведите первые n числе фибоначчи
// Если N = 5 --> 0 1 1 2 3 
// Если N = 7 --> 0 1 1 2 3 5 8

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1)+f(n-2)

Console.Clear();

/*
double Fibonacci(int n)
{
	if(n == 1 || n == 2) return 1;
	else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 5; i++)
{
	Console.Write($"{Fibonacci(i)} ");
}

Console.WriteLine();
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int num)
{
int[] arr = new int[num];
arr[1] = 1;
for (int i = 2; i < num; i++)
{
arr[i]=arr[i-1] + arr[i-2];
}
return arr;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

int [] resultArray = Fibonacci(number);
Console.WriteLine($"Первые {number} чисел Фибоначчи:");
PrintArray(resultArray);
