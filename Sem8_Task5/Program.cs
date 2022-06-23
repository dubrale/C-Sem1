/*Заполните спирально массив 4 на 4
(Заполняется любой квадратный)*/

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
    int currentFirstRow = 0;
    int currentLastRow = matrix.GetLength(0) - 1;
    int currentFirstColumn = 0;
    int currentLastColumn = matrix.GetLength(1) - 1;
    int count = 1;
    int final = matrix.GetLength(0) * matrix.GetLength(1);
    while (count <= final)
    {
        for (int i = 0; i <= currentLastColumn; i++)
        {
            matrix[currentFirstRow, i] = count;
            count++;
        }
        currentFirstRow++;
        for (int i = currentFirstRow; i <= currentLastRow; i++)
        {
            matrix[i, currentLastColumn] = count;
            count++;
        }
        currentLastColumn--;
        for (int i = currentLastColumn; i >= currentFirstColumn; i--)
        {
            matrix[currentLastRow, i] = count;
            count++;
        }
        currentLastRow--;
        for (int i = currentLastRow; i > currentFirstRow; i--)
        {
            matrix[i, currentFirstColumn] = count;
            count++;
        }
        currentFirstColumn++;
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
            Console.Write($"{matrix[i, j]}     ");
        }
        Console.WriteLine();
    }
}
int myMatrixSize = GetPositiveNumber("Введите размер матрицы:");
int[,] myMatrix = FillMatrix(myMatrixSize, myMatrixSize);
PrintMatrix(myMatrix);