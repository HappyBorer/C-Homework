/* Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц. */

using static System.Console;
Clear();


// Методы

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

double ElementProduct(int[,] massif)
{
    double workElement = 1;
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int j = 0; j < massif.GetLength(1); j++)
        {
            workElement *= massif[i, j];
        }
    }
    return workElement;
}
// Начало кода

int sizeRowFirst = InputNumber("Введите количество строк первой матрицы: ");
int sizeColumnFirst = InputNumber("Введите количество столбцов первой матрицы: ");
int sizeRowSecond = InputNumber("Введите количество строк второй матрицы: ");
int sizeColumnSecond = InputNumber("Введите количество столбцов второй матрицы: ");
int[,] arrayInt = new int[sizeRowFirst, sizeColumnFirst];
int[,] arrayNumbers = new int[sizeRowSecond, sizeColumnSecond];

FillArrayNambers(arrayInt);

FillArrayNambers(arrayNumbers);

PrintArray(arrayInt);

PrintArray(arrayNumbers);

double matrixProduct = ElementProduct(arrayInt) * ElementProduct(arrayNumbers);

WriteLine("Произведение двух матриц = {0}", matrixProduct);



