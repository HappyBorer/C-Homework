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
    // Способ первый через конкатенацию

    /*string figure = String.Empty;
    while (num > 0)
    {
        int result = num % 10;
        figure += Convert.ToString(result);
        num /= 10;

    }
    return Convert.ToInt32(figure); */

    // Способ второй через математические операции

    int result = 0;
    while(num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result; 
}
if (number == NumberFlip(number))
{
    WriteLine($"Число {number} является палиндромом");
}
else
{
    WriteLine($"Число {number} не является палиндромом");
}
