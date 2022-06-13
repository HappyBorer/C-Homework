/* Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, 
когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля */

using static System.Console;
Clear();
void SetName()
{
    WriteLine("Установить имя");
}
void Help()
{
    WriteLine("Список команд: ");
    WriteLine("SetName – Установить имя\nHelp – Вывести список команд\nSetPassword – Установить пароль");
    WriteLine("WriteName – Вывести имя после ввода пароля\nExit – выход");
}
void SetPassword()
{
    WriteLine("Установить пароль");
}
void WriteName()
{
    WriteLine("Вывести имя после ввода пароля");
}
void Menu(string line)
{
    if (line == "SetName")
    {
        SetName();
    }
    else if (line == "Help")
    {
        Help();
    }
    else if (line == "SetPassword")
    {
        SetPassword();
    }
    else if (line == "WriteName")
    {
        WriteName();
    }
    else 
    {
        WriteLine("Такая команда отсутствует! Введите команду из списка!");
    }
}

string line = "Добро пожаловать";
while(true)
{
    Help();
    Write("Выберите команду: ");
    line = ReadLine();
    Clear();
    if (line == "Exit")
    {
        Write("Вы хотите выйти? Y(Да), N(Нет): ");
        line = ReadLine();
        if(line == "Y")
        {
            return;
        }
        else
        {
            continue;
        }
    }
    Menu(line);
}