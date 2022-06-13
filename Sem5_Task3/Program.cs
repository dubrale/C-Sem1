/*Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементом массива.
[3 7 22 2 78] -> 76*/

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd  =new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-40,40);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();     
}
int FindMaxItem(int[] array)
{
    int max = array[0];
    int length = array.Length;
    foreach (int item in array)
    {
        if (item > max)
        max = item;
    }
    return max;
}
int FindMinItem(int[] array)
{
    int min = array[0];
    int length = array.Length;
    foreach (int item in array)
    {
        if (item < min)
        min = item;
    }
    return min;
}
void FindDiffMaxMinItems(int maxItem, int minItem)
{
    int diff = Math.Abs(maxItem - minItem);
    Console.WriteLine($"Разница между максимальным и минимальным: {diff}");
}
Console.WriteLine("Введите длину массива");
int myLength = int.Parse(Console.ReadLine());
int[] myArray = FillArray(myLength);
PrintArray(myArray);
int myMax = FindMaxItem(myArray);
Console.WriteLine($"максимальный элемент: {myMax}");
int myMin = FindMinItem(myArray);
Console.WriteLine($"минимальный элемент: {myMin}");
FindDiffMaxMinItems(myMax,myMin);
