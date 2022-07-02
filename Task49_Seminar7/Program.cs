//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
// квадраты. Например, изначально массив  выглядел вот так:
// 1 4 7 2                  
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.WriteLine("Введите количество строк m массива: ");
byte num1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите количество количество столбцов n массива: ");
byte num2 = Convert.ToByte(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] arr = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1,11);
        }       
    }
    return arr;
}
void PrintArray(int [,] arr)
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

int [,] ReplaceElements(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0)
            {
                arr[i,j] *=  arr[i,j];
            }
        }       
    }
    return arr;
}

int[,] arrayRes = GetArray(num1, num2);
PrintArray(arrayRes);
System.Console.WriteLine();
int[,] newarray = ReplaceElements(arrayRes);
PrintArray(newarray);

