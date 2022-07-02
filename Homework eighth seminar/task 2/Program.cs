/* Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов. */


using static System.Console;
Clear();


// методы

int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

void FillArrayNambers(int[,] massif)
{
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int j = 0; j < massif.GetLength(1); j++)
        {
            massif[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
    WriteLine();
}

void FindLowestSumString(int[,] arrayInt)
{
    int indexLowestAmount = 0;
    int lowestAmount = int.MaxValue;
    for (int i = 0; i < arrayInt.GetLength(0); i++)
    {
        int sumOf = 0;
        for (int j = 0; j < arrayInt.GetLength(1); j++)
        {
            sumOf += arrayInt[i, j];
        }
        if (lowestAmount > sumOf)
        {
            lowestAmount = sumOf;
            indexLowestAmount = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой номер {indexLowestAmount + 1}, её сумма = { lowestAmount}\nи сама строка: ");
    for (int i = 0; i < arrayInt.GetLength(1); i++)
    {
        Write($"{arrayInt[indexLowestAmount, i]}\t");
    }
}

// Начало программы

int squareSide = InputNumber("Введите стороны квадратной матрицы: ");

int[,] arrayInt = new int[squareSide, squareSide];

FillArrayNambers(arrayInt);

PrintArray(arrayInt);

FindLowestSumString(arrayInt);







