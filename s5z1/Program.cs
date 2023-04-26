// // Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2
Console.Clear();
int[] array = GetRandomArray(1000);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество четных числе {EvenNumArray(array)}");
int[] GetRandomArray(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
int EvenNumArray(int[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0) count++;
    }
    return count;
}