/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]*/
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int number))
            return number;
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это не число");
            Console.ResetColor();
        }
    }
}
void FillArray(int[] fillArr)
{
    int arraySize = fillArr.Length;
    for (int i = 0; i < arraySize; i++)
    {
        fillArr[i] = GetNumber($"Введите {i}-й элемент массива");
    }
}
void PrintArray(int[] printArr)
{
    int arraySize = printArr.Length;
    Console.Write("{");
    for (int i = 0; i < arraySize-1; i++)
    {
        Console.Write(printArr[i] + ",");
    }
    Console.Write(printArr[arraySize-1]);
    Console.Write("}");
}
int myArraySize = GetNumber("Введите размер массива");
int[] myArray = new int[myArraySize];
FillArray(myArray);
PrintArray(myArray);

