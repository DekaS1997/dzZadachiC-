// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] startArray = GetArray(10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {SumOfOddPos(startArray)}");

int[] GetArray(int array)
{
    int[] res = new int[array];
    for(int i = 0; i < array; i++)
    {
        res[i] = new Random().Next(1, 100);
    }
    return res;
}
int SumOfOddPos(int[] num)
{
    int sum = 0;
    for(int i = 0; i < num.Length; i+=2)
    {
        sum = sum + num[i];
    }
    return sum;
}