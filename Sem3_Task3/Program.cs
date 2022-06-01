/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125*/
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int number))
            if (number > 0)
                return number;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Число меньше 1");
                Console.ResetColor();
            }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это не координата");
            Console.ResetColor();
        }
    }
}
void GetCubed(int N)
{
    for (int i = 1; i < N + 1; i++)
        Console.Write($"{i * i * i} ");
}
string myMessage = "Введите число, не меньшее 1";
int myN = GetNumber(myMessage);
GetCubed(myN);
