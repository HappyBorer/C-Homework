 /*В переменной string есть секретное сообщение, во второй есть пароль. 
 Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/
string classifiedMessage = "Купил слона";
string password = "СЛОН";
string inputPassword = "";
int attempt = 3;
int count = 1;
Console.WriteLine("Он трубит, но не трубач,");
Console.WriteLine("Всеми признанный силач.");
Console.WriteLine("Стоя спит под пальмой он.");
while(count <= attempt && inputPassword != password)
{
    Console.Write(count + " попытка ввода пароля: ");
    inputPassword =  Console.ReadLine();
    if(inputPassword == password)
    {
        Console.WriteLine(classifiedMessage);
    }
    else
    {
        Console.WriteLine("Неверный пароль");
    }
    count++;
}
if (count > attempt)
{
    Console.WriteLine("Попытки закончились");
}