//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а 
//первый - на последнем и т.д.) [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите элементы массива через пробел: ");
int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(string.Join(" ", array));
int size = array.Length;
int index1 = 0;
int index2 = size - 1;
while (index1 < index2)
{
    int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
    index1++;
    index2--; 
}
Console.WriteLine(string.Join(" ", array));
