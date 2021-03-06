/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Console.Clear();
int size = 10;

int[] arrayInt = new int[size];

int[] FillArrayRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
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

arrayInt = FillArrayRandom(arrayInt);

void SumOddIndexArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма элементов стоящих  на нечётных позициях = {sum}");
}
PrintArray(arrayInt);
SumOddIndexArray(arrayInt);