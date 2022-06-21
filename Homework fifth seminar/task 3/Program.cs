/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
void PrintArray(double[] arr)
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

int size = 5;

double[] arrayDouble = new double[size];

double[] FillArrayRandom(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 99 + 1, 2);
    }
    return arr;
}

arrayDouble = FillArrayRandom(arrayDouble);
PrintArray(arrayDouble);

void FindDiffMaxMinElement(double[] arr)
{
    double max = arr[0];
    double min = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    double result = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");
}

FindDiffMaxMinElement(arrayDouble);