/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

using static System.Console;
Clear();
int Input(string figure)
{
    Write(figure);
    return Convert.ToInt32(ReadLine());
}

int numberN = Input("Введите число: ");

int PowMy(int num, int i)
{
    int result = 1;
    if (i == 0)
    {
        return result;
    }
    while (i > 0)
    {
        result *= num;
        i--;
    }
    return result;
}

int count = 1;

while (count < numberN)
{
    Write($"{PowMy(count, 3)}, ");
    count++;
}
WriteLine(PowMy(numberN, 3));