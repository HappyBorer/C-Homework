/* Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива. */

// Методы
using static System.Console;
Clear();

void PlenumArrayNambers(int[,] massif)
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

int[,] SortArrayByRows(int[,] massif)
{
    for (int k = 0; k < massif.GetLength(0); k++)
    {
        for (int i = 0; i < massif.GetLength(0); i++)
        {
            for (int j = massif.GetLength(1) - 1; j > 0; j--)
            {
                if (massif[i, j] > massif[i, j - 1])
                {
                    int temp = massif[i, j];
                    massif[i, j] = massif[i, j - 1];
                    massif[i, j - 1] = temp;
                }
            }
        }
    }
    return massif; 
}


// Начало программы

int rows = 7;
int columns = 9;

int[,] arrayNumbers = new int[rows, columns];

PlenumArrayNambers(arrayNumbers);

WriteLine("Массив до сортировки");
PrintArray(arrayNumbers);

arrayNumbers = SortArrayByRows(arrayNumbers);

WriteLine("Массив  сортировки");
PrintArray(arrayNumbers);



