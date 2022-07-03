// Заполните спирально массив 4 на 4.

using static System.Console;
Clear();

// Методы

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



// Мой код

int row = 4, column = row;
int[,] arrayInt = new int[row, column];
int step = 1, stepI = 0, stepJ = 0;
while (step <= arrayInt.Length)
{
    arrayInt[stepI, stepJ] = step++;
    if (stepI <=  stepJ + 1 && stepI + stepJ < arrayInt.GetLength(1) - 1)
    {
        stepJ++;
    }
    else if (stepI < stepJ && stepJ + stepI >= arrayInt.GetLength(0) - 1)
    {
        stepI++;
    }
    else if (stepI >= stepJ && stepI + stepJ > arrayInt.GetLength(1) - 1 )
    {
        stepJ--;
    }
    else
    {
        stepI--;
    }
}

PrintArray(arrayInt);
