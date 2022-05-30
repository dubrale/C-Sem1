/*Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным*/
Console.WriteLine("Введите номер дня недели");
int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber > 0 && dayNumber < 8)
    if (dayNumber > 0 && dayNumber < 6)
        Console.WriteLine("Это будний день");
    else
        Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Дней всего 7");