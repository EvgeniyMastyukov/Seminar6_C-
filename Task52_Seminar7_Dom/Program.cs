// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк m массива: ");
short rows = short.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n массива: ");
short columns = short.Parse(Console.ReadLine());

double[,] GetArray(int a, int b)
{
    double[,] arr = new double[a, b];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMidle(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sumMidle = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sumMidle += arr[j, i] / arr.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое элементов  {i}  столбца = {sumMidle}");
    }
}
double[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
FindMidle(array);
