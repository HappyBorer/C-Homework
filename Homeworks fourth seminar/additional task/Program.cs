/* Конвертер валют. У пользователя есть баланс в каждой из представленных валют.
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент,
когда решит пользователь. */

using static System.Console;
Clear();
void Conversion(double[] account, int choice, int check)
{
    double[] conversionRuble = { 1, 56.71, 59.32, 8.50 };
    double total = account[check - 1] * conversionRuble[check - 1] / conversionRuble[choice - 1];
    WriteLine($"Итого: {Math.Round(total, 2)}");
    ReadKey();
}
double[] checkYour = { 3750.65, 300.85, 1500.34, 2190.57 };
bool flag = true;
while (flag == true)
{
    Clear();
    WriteLine($"Вашы счета:\nРублёвый \t{checkYour[0]}\nДолларовый \t{checkYour[1]}\nЕвровый \t{checkYour[2]}\nЮаневый \t{checkYour[3]}");
    WriteLine("Конвертационный калькулятор");
    WriteLine("1. В Рубль\n2. В Доллар\n3. В Евро\n4. В Юань\n5. Выход");
    Write("Выберите оперцию: ");
    int operation = Convert.ToInt32(ReadLine());
    if (operation < 1 || operation > 5)
    {
        WriteLine("Такой операции нет!");
    }
    if (operation == 5)
    {
        WriteLine("Вы хотите выйти: y(да), n(нет): ");
        string answer = ReadLine();
        if (answer.ToLower() == "y")
        {
            flag = false;
            break;
        }
        else
        {
            continue;
        }
    }
    Clear();
    WriteLine($"Вашы счета:\n1. Рублёвый \t{checkYour[0]}\n2. Долларовый \t{checkYour[1]}\n3. Евровый \t{checkYour[2]}\n4. Юаневый \t{checkYour[3]}");
    Write("Выберите счёт: ");
    int check = Convert.ToInt32(ReadLine());
    if (check < 1 || check > 4)
    {
        WriteLine("Нет такого счёта");
        ReadKey();
    }
    else
    {
        Conversion(checkYour, operation, check);
    }

}
