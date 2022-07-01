//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение переменной b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной b2: ");
float b2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите значение переменной k2: ");
float k2 = float.Parse(Console.ReadLine());
float x;
float y1 = k1 * (b2 - b1) / (k1 - k2) + b1;
float y2 = k2 * (b2 - b1) / (k1 - k2) + b2;
// y1 == y2;
// k1* x + b1 == k2 * x + b2;
// k1* x - k2*x == b2 - b1;
// (k1 - k2) * x == b2 - b1;

x = (b2 - b1) / (k1 - k2);

if ((k1 - k2) == 0)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
Console.WriteLine("Координаты точки пересечения двух прямых ({0};{1})", x, y1);
