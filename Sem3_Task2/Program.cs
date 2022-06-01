/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
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
            Console.WriteLine("Это не координата");
            Console.ResetColor();
        }
    }
}
double GetVectorLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double difX = Math.Pow((x2 - x1), 2);
    double difY = Math.Pow((y2 - y1), 2);
    double difZ = Math.Pow((z2 - z1), 2);
    double vectorLength = Math.Pow((difX + difY + difZ), 0.5);
    return vectorLength;
}
int myx1 = GetNumber("Введите координату x1");
int myy1 = GetNumber("Введите координату y1");
int myz1 = GetNumber("Введите координату z1");
int myx2 = GetNumber("Введите координату x2");
int myy2 = GetNumber("Введите координату y2");
int myz2 = GetNumber("Введите координату z2");
double resault = GetVectorLength(myx1, myy1, myz1, myx2, myy2, myz2);
Console.WriteLine($"Длина вектора = {resault}");