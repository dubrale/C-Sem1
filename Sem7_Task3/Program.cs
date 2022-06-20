/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
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
            matrix[i,j] = rnd.Next(1,10);
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
void FindMatrixRowsAvg(int [,] matrix)
{
    Console.WriteLine("Средние значения по строкам:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        float rowAvg = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowAvg += matrix[i,j];
        }
    rowAvg /= matrix.GetLength(0); 
    Console.WriteLine($"Среднее арифметическое {i+1}-й строки = {rowAvg}");
    }
}
int myRows = GetPositiveNumber("Введите число строк:");
int myColumns = GetPositiveNumber("Введите число столбцов:");
int [,] myMatrix = FillMatrix(myRows, myColumns);
PrintMatrix(myMatrix);
FindMatrixRowsAvg(myMatrix);