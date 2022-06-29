// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Write("Введите элементы массива через пробел: ");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(string.Join(" ", arr));

void CopyArr(int[] array)
{
    Console.WriteLine("Копия заданного массива: ");
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
        Console.Write($"{copy[i]} ");
    }
    
}

CopyArr(arr);