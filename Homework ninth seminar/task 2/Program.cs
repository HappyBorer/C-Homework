/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static System.Console;
Clear();

// Методы


int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

int SumNuturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    if (firstNumber < secondNumber)
    {
        return secondNumber + SumNuturalNumbers(firstNumber, secondNumber - 1);
    }
    if (firstNumber > secondNumber)
    {
        return firstNumber + SumNuturalNumbers(firstNumber - 1, secondNumber);
    }
    return secondNumber;
}

// Мой код

int m, n;
while (true)
{
    m = InputNumber("Введите натуральное число m: ");
    n = InputNumber("Введите натуральное число n: ");
    if (m < 1 || n < 1) WriteLine("Число не натуральное!");
    else break;
}

int sumNumbers = SumNuturalNumbers(m, n);

WriteLine($"Сумма натуральных чисел в диапазоне от {m} до {n} равна {sumNumbers}");
