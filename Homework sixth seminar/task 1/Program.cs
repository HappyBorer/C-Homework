/*Пользователь вводит с клавиатуры числа через запятую. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

using static System.Console;
Clear();

Write("Введите числа через запятую: ");
string inputNumbers = $"{ReadLine()} ";


int count = 0;
int figure = 0;
bool sign = false;
for (int i = 0; i < inputNumbers.Length; ++i)
{
    if (inputNumbers[i] == '-')
    {
        sign = true;
        i++;
    }
    if (inputNumbers[i] >= '0' && inputNumbers[i] <= '9')
    {
        figure = figure * 10 + (inputNumbers[i] - '0');
        continue;
    }
    if (sign == true)
    {
        figure *= -1;
        sign = false;
    }
    if (figure > 0)
    {
        count++;
    }
    figure = 0;
}
WriteLine($"Пользователь ввёл чисел больше 0 = {count}");



