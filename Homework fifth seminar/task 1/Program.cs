/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
int size = 6;
int[] arrayIntegers = new int[size];

int[] FillArrayRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write(arr[i] + ".");
        }
    }
    Console.WriteLine();
}

void SearchEvenNembersArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Чётных чисел в массиве = {count}");
}
arrayIntegers = FillArrayRandom(arrayIntegers);
PrintArray(arrayIntegers);
SearchEvenNembersArray(arrayIntegers);

