/* Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное
число или меньше. На отгадывание дается 3 попытки. */

Console.Clear();
void NumberCompar(int numGue, int tr)
{
    while(tr > 0)
    {   
        Console.Write($"Осталось попыток {tr}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > numGue)
        {
            Console.WriteLine("Неправильно. Угадываемое число меньше!");
        }
        else if (number < numGue)
        {
            Console.WriteLine("Неправильно. Угадываемое число больше!");
        }
        else 
        {
            Console.WriteLine("Ты угадал!!!");
            break;
        }   
        tr--;
        if (tr == 0)
        {
            Console.WriteLine("Попытки кончились.");
        }
}
}
int numberGuess = new Random().Next(1, 1000);
Console.WriteLine("Угадай число от 1 до 1000");
int attempt = 3;
NumberCompar(numberGuess, attempt);