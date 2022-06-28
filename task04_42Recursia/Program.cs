//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101  3 -> 11 
//2 -> 10
Console.Write("Введите положительное десятичное число: "); //Второй вариант.
int numDec = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

void DecToOther(int num, int baseN)
{
    if (num == 0)
    {
        return;
    }
    DecToOther(num/baseN, baseN);
    Console.Write($"{num%baseN}");
}

DecToOther(numDec, baseNum);