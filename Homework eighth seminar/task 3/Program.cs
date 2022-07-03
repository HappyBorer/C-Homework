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

int[,] ElementProduct(int[,] massif, int[,] array)
{
    int[,] matrixProduct = new int[massif.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int j = 0; j < massif.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                matrixProduct[i, j] += massif[i, k] * array[k, j];
                
            }
        }
    }
    return matrixProduct;
}
// Начало кода

int sizeRowColumn = InputNumber("Введите размер матриц: ");
int[,] arrayInt = new int[sizeRowColumn, sizeRowColumn];
int[,] arrayNumbers = new int[sizeRowColumn, sizeRowColumn];

FillArrayNambers(arrayInt);

FillArrayNambers(arrayNumbers);
WriteLine("Первая матрица:");
PrintArray(arrayInt);
WriteLine("Вторая матрица:");
PrintArray(arrayNumbers);
int[,] matrixProduct = ElementProduct(arrayInt, arrayNumbers);
WriteLine("Результат произведения матриц:");
PrintArray(matrixProduct);



