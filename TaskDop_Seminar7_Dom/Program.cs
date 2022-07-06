//Доп. задание. Задать целочисленный двумерный массив размерности n х m.  Выяснить, в какой строке последовательность
// является возрастающей или убывающей.

Console.Write("Введите количество строк n массива: ");
short rows = short.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов m массива: ");
short columns = short.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] arr = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(100);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
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
int[,] array = GetArray(rows, columns);
PrintArray(array);

void FindOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int count = 0;
        int regres = 0;
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[i, j] < arr[i, j + 1]) count++;
            else if (arr[i, j] > arr[i, j + 1]) regres++;
            // Console.WriteLine($"count = {count} regres = {regres}");
        }
        if (count + 1 == arr.GetLength(1)) Console.WriteLine($"Последовательность {i} строки возрастающая");
        else if (regres + 1 == arr.GetLength(1)) Console.WriteLine($"Последовательность {i} строки убывающая");
        else Console.WriteLine("НЕТ");

    }
}
FindOrder(array);