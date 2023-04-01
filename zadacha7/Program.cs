/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.Write("Ввести день невдели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if(numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправельный номер: ");
    return;
}
if(numberDayOfWeek < 5)
{
    Console.WriteLine("Будни");
}
else if(numberDayOfWeek > 5)
{
Console.WriteLine("Выходной");
}
