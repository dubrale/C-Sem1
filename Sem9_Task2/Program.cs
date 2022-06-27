/*Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
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
int NumbersFromMToNSum(int M, int N, int sum)
{
    while (true)
    {
        if (N < M)
        {
            Console.Write($"N < M. N должно быть больше или равно M");
            System.Environment.Exit(0);
        }
        else
            if (M < N)
            {    
                sum += M;
                return NumbersFromMToNSum(M + 1, N, sum);
            }
            else
                sum += N;
                return sum;
    }
}
int myM = GetPositiveNumber("Введите число M");
int myN = GetPositiveNumber("Введите число N");
int mySum = 0;
int result = NumbersFromMToNSum(myM, myN, mySum);
Console.WriteLine($"Сумма чисел от M до N = {result}");