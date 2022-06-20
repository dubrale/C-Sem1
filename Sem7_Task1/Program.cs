/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
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
double [,] FillMatrix(int rows, int columns)
{
    double [,] matrix = new double [rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble()*rnd.Next(-10,11), 1);
        }
    }
    return matrix;
}
void PrintMatrix(double [,] matrix)
{
    Console.WriteLine("Матрица:");
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}   ");
        }
    Console.WriteLine();
    }
}
int myRows = GetPositiveNumber("Введите число строк:");
int myColumns = GetPositiveNumber("Введите число столбцов:");
double [,] myMatrix = FillMatrix(myRows, myColumns);
PrintMatrix(myMatrix);