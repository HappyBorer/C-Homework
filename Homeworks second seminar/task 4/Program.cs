/* Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

int Square(int num)
{
    return num * num;
}
int Invite(string input)
{
    Console.Write(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
Console.Clear();

int firstNumber = Invite("Введите первое число: ");

int secondNumber = Invite("Введите второе число: ");

if (Square(firstNumber) == secondNumber || Square(secondNumber) == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}