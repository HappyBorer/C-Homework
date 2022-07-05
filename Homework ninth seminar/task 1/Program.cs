/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// Методы
using static System.Console;
Clear();


int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

void Backing(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        Backing(number - 1);
    }
    else
    {
        Console.Write($"{number} ");
    }
}


// Мой код

int number;
while (true)
{
    number = InputNumber("Введите натуральное число: ");
    if (number < 1) WriteLine("Число не натуральное!");
    else break;
}
Backing(number);