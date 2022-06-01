/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом 
14212 -> нет
23432 -> да
12821 -> да
*/
string GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (ValueFromConsole.Length == 5)
        {
            if (int.TryParse(ValueFromConsole, out int intNumber))
            {
                string outNumber = Convert.ToString(intNumber);
                return outNumber;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не число");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это не пятизначное число");
            Console.ResetColor();
        }
    }
}
void PalindromeTest(string someNumber)
{
    if (someNumber[0] == someNumber[4] && someNumber[1] == someNumber[3])
        Console.WriteLine("Число - палиндром");
    else
    {
        Console.WriteLine("Число - не палиндром");
    }
}

string myMessage = "Введите пятизначное число";
string myNumber = GetNumber(myMessage);
PalindromeTest(myNumber);