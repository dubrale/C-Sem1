/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

int GetHowManyNumbers(string msg)
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
int CountPositiveFromNNumbers(int n, int countPos, int step)
{
    if (n != 0)
    {
        int number = GetNumber($"Введите {step}-ое число");
        if (number > 0)
            return CountPositiveFromNNumbers(--n, ++countPos, ++step);
        else
        {
            return CountPositiveFromNNumbers(--n, countPos, ++step);   
        } 
    }
    else
    {
        return countPos;
    }
}
int myN = GetHowManyNumbers("Сколько чисел будете вводить?");
Console.WriteLine();
Console.WriteLine($"Среди введенных чисел положительных: {CountPositiveFromNNumbers(myN,0,1)}");
// Вариант без рекурсии (заменить строчки с ... по ... )
// int CountPositiveFromNNumbers(int n)
// {
//     int count = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         int number = GetNumber($"Введите {i}-ое число");
//         if (number > 0)
//             count++;
//     }
//     Console.WriteLine($"Из них положительных: {count}");
// }
// int myN = GetHowManyNumbers("Сколько чисел будете вводить?");
// Console.WriteLine();
// CountPositiveFromNNumbers(myN);