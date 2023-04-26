/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.Write("Введите число: ");
int numDayOfWeek = int.Parse(Console.ReadLine());

if(numDayOfWeek < 1 || numDayOfWeek > 7)
{
    Console.WriteLine("Такого дня недели нет");
    return;
}
if(numDayOfWeek <= 5)
{
    Console.WriteLine("Будни");
}else if(numDayOfWeek >= 6)
{
    Console.WriteLine("Выходной");
}
