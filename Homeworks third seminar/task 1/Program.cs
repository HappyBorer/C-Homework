/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

using static System.Console;
Clear();
Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());
if (number < 10000 || number > 99999)
{
    WriteLine("Ошибка! Чиcло не пятизначное!");
    return;
}
int NumberFlip(int num)
{
    string figure = " ";
    while (num > 0)
    {
        int result = num % 10;
        figure += Convert.ToString(result);
        num /= 10;

    }
    return Convert.ToInt32(figure);
}
if (number == NumberFlip(number))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
