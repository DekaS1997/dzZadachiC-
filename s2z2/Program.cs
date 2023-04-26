/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int thirdDigit(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
if (number < 100)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра: {thirdDigit(number)}");
