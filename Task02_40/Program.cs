//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со
// сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
//двух других сторон.
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третьте число: ");
int num3 = int.Parse(Console.ReadLine());
if((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 <num1 + num2))
{
   Console.WriteLine($"Треугольник со сторонами {num1}, {num2},{num3} может существовать"); 
}
else Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} не может существовать"); 