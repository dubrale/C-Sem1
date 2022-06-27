/*Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"*/
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
void PrintNumbersFromMToN(int M, int N)
{
    if (N < M)
        Console.Write($"N < M. N должно быть больше или равно M");
    else
        if (M < N)
        {
            Console.Write($"{M}, ");
            PrintNumbersFromMToN(M + 1, N);
        }
        else
            Console.Write($"{N}");
}
int myM = GetPositiveNumber("Введите число M");
int myN = GetPositiveNumber("Введите число N");
PrintNumbersFromMToN(myM, myN);