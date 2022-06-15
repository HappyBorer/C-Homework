/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int ReductionNumber(int num)
{
    while (num > 999)
    {
        num /= 10; 
    }
  return num;
}
int thirdDigit(int dig)
{
    int thirdD = ReductionNumber(dig) % 10;
    return thirdD;
}
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{ 
    Console.WriteLine(thirdDigit(number));
}
