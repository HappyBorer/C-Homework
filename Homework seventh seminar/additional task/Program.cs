/*Написать программу со следующими командами:
- SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
- AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
- RemoveNumbers -  пользователь вводит числа, которые если  найдутся в массиве, то будут удалены
- Numbers – ввывод текущего массива
- Sum – найдется сумма всех элементов чисел */


using static System.Console;
Clear();

int[] SetNumbers(string outcome)
{
    int countNumbers = 1;
    for (int i = 0; i < outcome.Length; i++)
    {
        if (outcome[i] == ' ')
            countNumbers++;
    }
    int[] arrayNumbers = new int[countNumbers];
    int index = 0;

    for (int i = 0; i < outcome.Length; i++)
    {

        string timesString = String.Empty;
        while (outcome[i] != ' ')
        {
            timesString += outcome[i].ToString();
            if (i != outcome.Length - 1) i++;
            else break;
        }
        arrayNumbers[index++] = Convert.ToInt32(timesString);

    }
    return arrayNumbers;
}

int[] AddNumbers(int[] array, string output)
{
    int countNumbers = 1;
    for (int i = 0; i < output.Length; i++)
    {
        if (output[i] == ' ')
            countNumbers++;
    }
    int[] newArrayNumbers = new int[countNumbers + array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArrayNumbers[i] = array[i];
    }

    int index = array.Length;

    for (int i = 0; i < output.Length; i++)
    {

        string timesString = String.Empty;
        while (output[i] != ' ')
        {
            timesString += output[i].ToString();
            if (i != output.Length - 1) i++;
            else break;
        }
        newArrayNumbers[index++] = Convert.ToInt32(timesString);

    }
    return newArrayNumbers;
}

int[] RemoveNumbers(int[] array, string output)
{
    int countNumbers = 1;
    for (int i = 0; i < output.Length; i++)
    {
        if (output[i] == ' ')
            countNumbers++;
    }
    int[] EnterNumberArray = new int[countNumbers];
    int index = 0;
    int countIndex = 0;
    for (int i = 0; i < output.Length; i++)
    {

        string timesString = String.Empty;
        while (output[i] != ' ')
        {
            timesString += output[i].ToString();
            if (i != output.Length - 1) i++;
            else break;
        }
        EnterNumberArray[index] = Convert.ToInt32(timesString);
        for (int j = 0; j < array.Length; j++)
        {
            if (EnterNumberArray[index] == array[j]) countIndex++;
        }
        index++;
    }

    if (countIndex == 0) return array;

    int[] arrayRemoteNumbers = new int[array.Length - countIndex];

    int newIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool checkIndex = false;
        for (int j = 0; j < EnterNumberArray.Length; j++)
        {
            if (array[i] == EnterNumberArray[j]) checkIndex = true;
        }
        if (checkIndex != true) arrayRemoteNumbers[newIndex++] = array[i];

    }

    return arrayRemoteNumbers;
}

void Numbers(int[] massif)
{
    for (int i = 0; i < massif.Length; i++)
    {
        Console.Write("{0} ", massif[i]);
    }
    Console.WriteLine();
}

void Sum(int[] massif)
{
    int total = 0;
    for (int i = 0; i < massif.Length; i++)
    {
        total += massif[i];
    }
    Console.WriteLine("Сумма всех элементов массива равна {0}", total);
}

Write("Введите числа через пробел: ");

int[] arrayInteger = SetNumbers(Console.ReadLine());

Numbers(arrayInteger);

Write("Введите числа через пробел для добавления в массив: ");

arrayInteger = AddNumbers(arrayInteger, Console.ReadLine());

Numbers(arrayInteger);

Write("Введите числа через пробел, найденные числа в массиве будут удалены: ");

arrayInteger = RemoveNumbers(arrayInteger, Console.ReadLine());

Numbers(arrayInteger);

Sum(arrayInteger);


