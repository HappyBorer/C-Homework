/* Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.Write("Введите возводимое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int total = 1;
for (int i = 0; i < degree; i++)
{
    total *= number;
}
Console.WriteLine($"{number} в {degree} степени {total}");