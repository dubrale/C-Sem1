/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов*/
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
int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Матрица:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void FindMatrixMinRowSum(int[,] matrix)
{
    int[] RowsArray = new int[matrix.GetLength(0)];
    Console.WriteLine("Сумма элементов по строкам:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        RowsArray[i] = rowSum;
        Console.WriteLine($"Сумма элементов {i + 1}-й строки = {rowSum}");
    }
    int minRowSum = RowsArray.Min();
    int minRowSumIndex = RowsArray.ToList().IndexOf(minRowSum);
    Console.WriteLine($"Минимальная сумма элементов у {minRowSumIndex + 1}-й строки");
}
int myRows = GetPositiveNumber("Введите число строк:");
int myColumns = GetPositiveNumber("Введите число столбцов:");
int[,] myMatrix = FillMatrix(myRows, myColumns);
PrintMatrix(myMatrix);
FindMatrixMinRowSum(myMatrix);