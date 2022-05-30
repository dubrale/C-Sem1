/*Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры 
нет.*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (number.Length > 2)
    Console.WriteLine($"третья цифра -> {number[2]}");
else
    Console.WriteLine($"число {number} слишком мало");