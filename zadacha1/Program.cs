/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
int min, max;
if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine($"Число {a} больше чем {b}");
}
if(b > a)
{
    max = b;
    min = a;
    Console.WriteLine($"Число {b} больше чем {a}");
}

