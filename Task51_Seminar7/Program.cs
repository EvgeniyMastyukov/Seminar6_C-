//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine("Введите количество строк m массива: ");
byte num1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите количество количество столбцов n массива: ");
byte num2 = Convert.ToByte(Console.ReadLine());

void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
        }
    }

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
int FindSumDiag(int[,] matrix)
{
   int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j) sum += matrix[i,j];

        }
    }   
    return sum;
}
int [,] arrayResult = new int [num1, num2];
FillArray(arrayResult);
PrintArray(arrayResult);

Console.Write($"Сумма элементв на главной диагонали =  ");
Console.WriteLine(FindSumDiag(arrayResult));