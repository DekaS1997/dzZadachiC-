
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
int SumDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр в числе {number} = {SumDigit(number)}");