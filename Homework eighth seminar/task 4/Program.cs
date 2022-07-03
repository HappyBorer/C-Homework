/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента. */

using static System.Console;
Clear();


// Методы

int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

void FillArrayNambers(int[,,] massif)
{
    for (int k = 0; k < massif.GetLength(0); k++)
    {
        for (int i = 0; i < massif.GetLength(1); i++)
        {
            for (int j = 0; j < massif.GetLength(2); j++)
            {
                massif[k, i, j] = UniqueNumbers(massif);
            }
        }
    }
}

int UniqueNumbers(int[,,] array)
{
    int number;
    while (true)
    {
        bool check = true;
        int optingPositiveNegative = new Random().Next(2);
        if (optingPositiveNegative != 0) number = new Random().Next(10, 100);
        else number = new Random().Next(-99, -9);
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(2); j++)
                {
                    if (array[k, i, j] == number)
                    {
                        check = false;
                        break;
                    }
                }
            }
        }
        if (check == true) return number;
    }
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Write("{0,3:0}", array[k, i, j]);
                Write($" [{k},{i},{j}]\t");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}

// Мой код


int axisZ, axisX, axisY;

while (true)
{
    axisZ = InputNumber("Введите глубину массива: ");
    axisX = InputNumber("Введите строки массива: ");
    axisY = InputNumber("Введите столбцы массива: ");
    if (axisX * axisY * axisZ > 178)
    {
        WriteLine("Слишком большой массив для двузначных неповторяющихся чисел!");
        WriteLine("Повторите ввод размера массива!");
    }
    else break;
}
int[,,] threeDimensionalArray = new int[axisZ, axisX, axisY];


FillArrayNambers(threeDimensionalArray);
PrintArray(threeDimensionalArray);

