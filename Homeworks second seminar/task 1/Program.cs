/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int figure2 = number % 100 / 10;
    Console.WriteLine(figure2);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}