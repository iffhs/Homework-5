// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Difference(int[] array)
{
    int a = int.MaxValue;
    int b = int.MinValue;
    foreach (int n in array)
    {
        if(n > b)
        {
            b = n;
        }
        if (n < a)
        {
            a = n;
        }
    }
    return b - a;
}

int[] array = CreateArray(6, 1, 20);
PrintArray(array);
Console.WriteLine($"Выводит разницу: {Difference(array)}");