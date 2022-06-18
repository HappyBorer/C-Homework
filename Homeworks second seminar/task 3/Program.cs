/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет  */

void weekFeed(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    }
    else if (0 < day && day < 6)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Такого дня не существует!");
    }
}
Console.Clear();
Console.Write("Введите день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
weekFeed(dayWeek);