// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4    1,7 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк m массива: ");
byte rows = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n массива: ");
byte columns = Convert.ToByte(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] arr = new int[a, b];
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
Console.Write("Укажите позицию строки элемента массива n: ");
int positionI = int.Parse(Console.ReadLine());
Console.Write("Укажите позицию столбца элемента массива n: ");
int positionJ = int.Parse(Console.ReadLine());
void FindIndexOf(int[,] arr, int x, int y)
{
    int find = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                find += arr[i, j];
                Console.WriteLine($"Элемент массива n[{x},{y}] = {find} ");
            }
            

        }
    }
}
int [,] array = GetArray(rows, columns);
PrintArray(array);
if(positionI>=rows || positionJ >=columns ) Console.WriteLine("Элемента n нет");
else FindIndexOf(array, positionI,positionJ);