// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк m массива: ");
byte rows = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n массива: ");
byte columns = Convert.ToByte(Console.ReadLine());

double[,] GetArray(int a, int b)
{
    double[,] arr = new double[a, b];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() + rnd.Next(-5,6); 
        }
    }
    return arr;
}
void PrintArray(double [,] arr)
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
double [,] arrayRes = GetArray(rows,columns);
PrintArray(arrayRes);