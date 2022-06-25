/*Написать метод Shuffle, который перемешивает 
элементы массива в случайном порядке.*/

Console.Clear();

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write(arr[i] + ".");
        }
    }
    Console.WriteLine();
}

int[] arrayInt = { 1, 2, 3, 4, 5, 6 };

int[] Shuffle(int[] massif)
{
    int[] newMassif = new int[massif.Length];
    for (int i = 0; i < newMassif.Length; i++)
    {
        int randomIndex = new Random().Next(massif.Length);
        newMassif[i] = massif[randomIndex];
        int[] arrayRemoteIndex = new int[massif.Length - 1];
        for (int j = 0; j < randomIndex; j++)
        {
            arrayRemoteIndex[j] = massif[j];
        }
        for (int j = randomIndex; j < arrayRemoteIndex.Length; j++)
        {
            arrayRemoteIndex[j] = massif[j + 1];
        }
        massif = arrayRemoteIndex;
    }
    return newMassif;
}
arrayInt = Shuffle(arrayInt);
PrintArray(arrayInt);

