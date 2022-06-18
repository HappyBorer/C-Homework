/*Есть программа с бесконечным циклом. Когда пользователь
вводит exit программа заканчивается*/

Console.Write("Ввод: ");
string line = Console.ReadLine();
while (line != "exit")
{
    Console.Write("Ввод: ");
    line = Console.ReadLine();
}