/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
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
int GetPositiveNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int number) && number > 0)
            return number;
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это не число или число меньше 0");
            Console.ResetColor();
        }
    }
}
int [,] FillMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(-3,4);
        }
    }
    return matrix;
}
void PrintMatrix(int [,] matrix)
{
    Console.WriteLine("Матрица:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}  ");
        }
    Console.WriteLine();
    }
}
void NumberInMatrixCheck(int [,] matrix, int number)
{
    int sum = 0;
    foreach (var item in matrix)
    {
        if (item == number)
            sum++;
    }
    if (sum == 0) 
        Console.WriteLine($"Числа {number} нет в матрице");
    else
        Console.WriteLine($"Число {number} есть в матрице");
}



int myRows = GetPositiveNumber("Введите число строк:");
int myColumns = GetPositiveNumber("Введите число столбцов:");
int [,] myMatrix = FillMatrix(myRows, myColumns);
PrintMatrix(myMatrix);
int myNumber = GetNumber("Введите число, чтобы узнать, есть ли оно в матрице:");
NumberInMatrixCheck(myMatrix, myNumber);