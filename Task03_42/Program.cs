//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101  3 -> 11 
//2 -> 10
// Console.WriteLine("Введите положительное число: ");
// int number = int.Parse(Console.ReadLine());
// int index = 0;
// double res = 0;
// int ost = number%2;
// int div = number/2;
//  Console.Write($"Двоичное представление числа {number} = ");
// while(number != 0)
// {
//     double num = ost * Math.Pow(10, index);                          
//     //Console.WriteLine($" {num}");
//     res = res + num;
//     ost = div%2;
//     div = div/2;
//     index++;
//     number = number/2;

// }
// Console.WriteLine($" {res}");

Console.Write("Введите положительное десятичное число: "); //Второй вариант.
int numDec = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());
int d10 = 1;
int result = 0;
while (numDec != 0)
{
    result = result + numDec % baseNum * d10;
    numDec = numDec / baseNum;
    d10 = d10 * 10;
}
Console.WriteLine($"{result}");