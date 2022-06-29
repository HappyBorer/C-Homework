/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


using static System.Console;
Clear();

int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}


int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");

double[,] arrayReal = new double[row, column];

void FillArrayRealNambers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(Convert.ToDouble(new Random().Next(-100, 100)) / new Random().Next(1, 11), 1); 
        }
    }
}

FillArrayRealNambers(arrayReal);

void PrintArrayReal(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Write("{0:0.00} ", array[i, j]);
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

PrintArrayReal(arrayReal);