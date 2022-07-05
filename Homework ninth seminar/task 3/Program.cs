/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using static System.Console;
Clear();

// Методы


int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}

int FunctionsAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FunctionsAckerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return  FunctionsAckerman(m - 1, FunctionsAckerman(m, n - 1));
    }
    return 0;
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

int number =  FunctionsAckerman(m, n);

WriteLine($"Функции Аккермана при m = {m} и n = {n}  будет равняться {number}");


