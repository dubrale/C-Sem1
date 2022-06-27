/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29*/
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
int Ackermann(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return Ackermann(n - 1, 1);
        else
            return Ackermann(n - 1, Ackermann(n, m - 1));
}
int myM = GetPositiveNumber("Введите число m");
int myN = GetPositiveNumber("Введите число n");
int result = Ackermann(myM, myN);
Console.WriteLine($"A({myM},{myN}) = {result}");