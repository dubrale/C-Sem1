/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 21);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
}
void EvenItemPositionSum(int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}
Console.WriteLine("Введите длину массива");
int myLength = int.Parse(Console.ReadLine());
int[] myArray = FillArray(myLength);
PrintArray(myArray);
EvenItemPositionSum(myArray);