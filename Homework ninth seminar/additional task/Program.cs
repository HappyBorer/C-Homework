/* Console.SetCursorPosition() - позволяет поставить курсор в какую-либо точку консоли
Console.CursorVisible - изменяет видимость курсора
Console.ReadKey() - ожидает нажатия клавиши на клавиатуре и возвращает ConsoleKeyInfo
В ConsoleKeyInfo.Key можно получить ConsoleKey - это нажатая пользователем клавиша

Задача написать игру-бродилку, где можно управлять персонажем стрелками вверх-вниз-влево-вправо. 
Область движения ограничена стенками ('*'), персонаж обозначается символом '@'. Область можно задать 
через двумерный массив. Персонаж должен иметь свободу движения в пределах его области. */


using static System.Console;
Clear();
// Методы



// Мой код
ConsoleKeyInfo key;
int height = 19;
int width = 10;
char person = '@';
int positionPersonX = 9;
int positionPersonY = 5;
WriteLine("Используйте для управления стрелочки на клавиатуре. Для выхода нажмите Escape");
WriteLine("Для продолжения нажмите любую клавишу.");
ReadKey();
Clear();
Console.SetCursorPosition(positionPersonX, positionPersonY);
Write(person);
while (true)
{
    Console.CursorVisible = false;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
            {
                Console.SetCursorPosition(i, j);
                Write('*');
            }


        }

    }
    //Write(' ');

    Console.SetCursorPosition(positionPersonX, positionPersonY);
    key = ReadKey();

    if (key.Key == ConsoleKey.UpArrow && positionPersonY > 1)
    {
        Write(' ');
        positionPersonY--;
        Console.SetCursorPosition(positionPersonX, positionPersonY);
    }
    else if (key.Key == ConsoleKey.DownArrow && positionPersonY < width - 2)
    {
        Write(' ');
        positionPersonY++;
        Console.SetCursorPosition(positionPersonX, positionPersonY);
    }
    else if (key.Key == ConsoleKey.LeftArrow && positionPersonX > 1)
    {
        Write(' ');
        positionPersonX--;
        Console.SetCursorPosition(positionPersonX, positionPersonY);
    }
    else if (key.Key == ConsoleKey.RightArrow && positionPersonX < height - 2)
    {
        Write(' ');
        positionPersonX++;
        Console.SetCursorPosition(positionPersonX, positionPersonY);
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        Clear();
        break;
    }

    Write(person);

}



