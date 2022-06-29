//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3  Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N чисел Фибоначчи: ");
int num = int.Parse(Console.ReadLine());

int[] arrFibo = new int[num];
void Fibonacci(int [] arr)
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }

}
void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Fibonacci(arrFibo);
PrintArray(arrFibo);

