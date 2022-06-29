/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using static System.Console;
Clear();

int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

int ItemPositionAcquisition =  InputNumber("Введите координаты элемента: ");
int rowNumber = ItemPositionAcquisition / 10;
int columnNumber = ItemPositionAcquisition % 10;

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

int row = 9;
int column = 9; 

int[,] arrayInt = new int[row, column];
PlenumArrayNambers(arrayInt);


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

PrintArray(arrayInt);

WriteLine();

if (rowNumber > arrayInt.GetLength(0) - 1 || columnNumber > arrayInt.GetLength(1) - 1 || rowNumber > 9)
{
    WriteLine("Такого элемента в массиве нет!");
}
else
{
    WriteLine($"Это место элемента - {arrayInt[rowNumber, columnNumber]}");
}


