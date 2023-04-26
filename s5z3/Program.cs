// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите номер в размере массива: ");
int b = int.Parse(Console.ReadLine());
int[] array = getarray(b, 1, 99);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Мин {FindMin(array)}, макс {FindMax(array)}, разница {FindMax(array) - FindMin(array)}");
int[] getarray(int size, int minv, int maxv)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minv, maxv + 1);
    }
    return a;
}
int FindMin(int[] array)
{
    int min = int.MaxValue;
    if (array.Length != 0)
    {
        foreach (int i in array)
        {
            if (i < min)
            {
                min = i;
            }
        }
    }
    return min;
}
int FindMax(int[] array)
{
    int max = int.MinValue;
    if (array.Length != 0)
    {
        foreach (int i in array)
        {
            if (i > max)
            {
                max = i;
            }
        }
    }
    return max;
}