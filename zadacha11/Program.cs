// // Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("b: ");
double b = double.Parse(Console.ReadLine());
double d = Math.Pow(a, b);
Console.WriteLine($"d = {d}");