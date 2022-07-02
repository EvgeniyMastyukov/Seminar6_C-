//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2   -1, -7, 567, 89, 223-> 3
// Console.WriteLine("Введите М чисел через пробел: ");
// int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Console.WriteLine(string.Join (" ", arr));
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {

//     if(arr[i] > 0) count++;

// }   
// Console.WriteLine($"Количество положительных чисел = {count}");

Console.WriteLine("Введите количество чисел для ввода до 255: ");
byte num = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите " + num + " чисел(а), после каждого числа нажмите Enter:" );
byte sum = 0;
byte count = 0;
while (sum < num)
{
    short number = short.Parse(Console.ReadLine());
    sum++;
    if(number > 0 ) count++;
}
Console.WriteLine($"Количество (+) чисел равно {count}");