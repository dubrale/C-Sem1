/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

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
void GetExponetation(int number1, int number2)
{
    double expoResult = Math.Pow(number1, number2);
    Console.WriteLine($"результат = {expoResult}");
}
int numberA = GetNumber("Введите число А");
int numberB = GetNumber("Введите число B");
GetExponetation(numberA, numberB);