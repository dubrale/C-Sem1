/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/
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
void GetDigitsSumm(int number)
{
    number = Math.Abs(number);
    int summ = 0;
    int reminder = 0;
    while (number != 0)
    {
        number = Math.DivRem(number, 10, out reminder);
        summ += reminder;
    }
    Console.WriteLine($"сумма цифр числа = {summ}");
}
int myNumber = GetNumber("Введите число, сумму цифр которого хотитие узнать");
GetDigitsSumm(myNumber);
