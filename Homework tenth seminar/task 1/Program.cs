/* Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
так чтобы в одной группе все числа в группе друг на друга не делились? Найдите M 
при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
Например, для N = 50, M получается 6
Группа 1: 1
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 7 16 24 36 40
Группа 6: 5 32 48

Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48 */

using static System.Console;
Clear();
// Методы.

int InputNumber(string output)
{
    Write(output);
    return Convert.ToInt32(ReadLine());
}


decimal[] Fill(decimal[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

decimal[] NumbersToFirstNumberWithRamainder(decimal[] array, int indexFirstNumber)
{
    int indexTemp = 0;
    decimal[] newArray = new decimal[array.Length / 2];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % array[indexFirstNumber] != 0 || array[i] / array[indexFirstNumber] == 1)
        {
            newArray[indexTemp++] = array[i];
        }
    }
    return newArray;
}

decimal[] RemoveNumbersSharedWithoutRemainder(decimal[] arrayNumberDeletion)
{
    decimal[] RemoveFromArray(decimal[] arr, int ind)
    {
        decimal[] newArray = new decimal[arr.Length - 1];
        for (int i = 0; i < ind; i++)
        {
            newArray[i] = arr[i];
        }
        for (int i = ind; i < newArray.Length; i++)
        {
            newArray[i] = arr[i + 1];
        }
        return newArray;
    }

    for (int i = 0; i < arrayNumberDeletion.Length; i++)
    {
        for (int j = i + 1; j < arrayNumberDeletion.Length; j++)
        {
            if (arrayNumberDeletion[j] == 0) break;
            else if (arrayNumberDeletion[j] % arrayNumberDeletion[i] == 0) arrayNumberDeletion = RemoveFromArray(arrayNumberDeletion, j);
        }

    }
    return arrayNumberDeletion;
}

void PrintArray(decimal[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0) break;
            Write($"{arr[i]} ");
        }
        WriteLine();
}

// Мой код.

int n = InputNumber("Введите число N: ");
int numberOfGroups = 0;

decimal[] arrayNumbers = new decimal[n];

arrayNumbers = Fill(arrayNumbers);




for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] != 0)
    {

        decimal[] arrayTemp = NumbersToFirstNumberWithRamainder(arrayNumbers, i);

        arrayTemp = RemoveNumbersSharedWithoutRemainder(arrayTemp);


        for (int j = 0; j < arrayNumbers.Length; j++)
        {
            for (int k = 0; k < arrayTemp.Length; k++)
            {
                if (arrayTemp[k] == arrayNumbers[j])
                {
                    arrayNumbers[j] = 0;

                }
            }
        }
        Write($"Группа {++numberOfGroups}: ");
        PrintArray(arrayTemp);
    }
}








