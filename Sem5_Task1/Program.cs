/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 998);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
}
void FindEven(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Всего четных элементов: {count}");
}
Console.WriteLine("Введите длину массива");
int myLength = int.Parse(Console.ReadLine());
int[] myArray = FillArray(myLength);
PrintArray(myArray);
FindEven(myArray);