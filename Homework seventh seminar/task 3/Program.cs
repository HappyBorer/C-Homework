/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



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
}

void SearchArithmeticMeanColumn(int[,] massif)
{
    Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < massif.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < massif.GetLength(0); j++)
        {
            sum += massif[j, i];
        }
        Write("{0} ", Math.Round((float)sum / massif.GetLength(0), 1));
    }
}


int row = 6;
int column = 6;

int[,] arrayNumbers = new int[row, column];

PlenumArrayNambers(arrayNumbers);

PrintArray(arrayNumbers);

SearchArithmeticMeanColumn(arrayNumbers);




