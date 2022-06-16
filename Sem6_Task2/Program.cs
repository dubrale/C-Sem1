/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/
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
string GetSign(int number)
{
    if (Math.Sign(number) < 0)
        return "-";
    else
        return "+";    
}   
void FindIntersection(int k1, int b1, int k2, int b2)
{
    
    if (k1 == k2)
        Console.WriteLine($"Прямые y=({k1})x+({b1}) и y=({k2})x+({b2}) параллельны");
    else
    {
        int x = (b2-b1)/(k1-k2);
        int y = (b1*k2-b2*k1)/(k2-k1);
        Console.WriteLine($"Точка пересечения прямых y={k1}x{GetSign(b1)}{Math.Abs(b1)} и y={k2}x{GetSign(b2)}{Math.Abs(b2)}: ({x},{y})");
    }
    
}
int myK1 = GetNumber("Задайте k1");
int myB1 = GetNumber("Задайте b1");
int myK2 = GetNumber("Задайте k2");
int myB2 = GetNumber("Задайте b1");
FindIntersection(myK1,myB1,myK2,myB2);