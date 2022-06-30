//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение переменной b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной k2: ");
int k2 = int.Parse(Console.ReadLine());
double x;
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
y1 == y2;
k1* x + b1 == k2 * x + b2;
k1* x - k2*x == b2 - b1;
(k1 - k2) * x == b2 - b1;
x = (b2 - b1) / (k1 - k2);
Console.WriteLine($"{x}");