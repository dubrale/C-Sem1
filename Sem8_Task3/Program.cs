/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMuptiplication(int[,] matrix1, int[,] matrix2)
{
    while (true)
    {
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            int[,] matrixMult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrixMult[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        matrixMult[i, j] += (matrix1[i, k]) * (matrix2[k, j]);
                    }
                }
            }
            return matrixMult;
        }
        else
        {
            Console.WriteLine("Операция невозможна. Число столбцов в первой матрице не равно числу строк во второй");
            System.Environment.Exit(0);
        }
    }
}
int myRows1 = GetPositiveNumber("Введите число строк первой матрицы:");
int myColumns1 = GetPositiveNumber("Введите число столбцов первой матрицы:");
int myRows2 = GetPositiveNumber("Введите число строк второй матрицы:");
int myColumns2 = GetPositiveNumber("Введите число столбцов второй матрицы:");
int[,] myMatrix1 = FillMatrix(myRows1, myColumns1);
Console.WriteLine();
Console.WriteLine("Первая матрица:");
Console.WriteLine();
PrintMatrix(myMatrix1);
int[,] myMatrix2 = FillMatrix(myRows2, myColumns2);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
Console.WriteLine();
PrintMatrix(myMatrix2);
int[,] myMatrixMult = MatrixMuptiplication(myMatrix1, myMatrix2);
Console.WriteLine();
Console.WriteLine("Произведение:");
Console.WriteLine();
PrintMatrix(myMatrixMult);