// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SearchOdd (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {    
        sum += array[i];
    }
    return sum;
}
int[] array = CreateArray(10, 1 , 20);
PrintArray(array);
Console.WriteLine($"Cумма нечётных {SearchOdd(array)}");