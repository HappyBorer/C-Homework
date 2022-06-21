/*Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – 
первая добавляет к числовому массиву значение,тем самым увеличивая массив, 
а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.*/


Console.Clear();
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i != arr.Length - 1)
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

int[] FillArrayRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 21);
    }
    return arr;
}


int[] arrayInt = new int[5];
arrayInt = FillArrayRandom(arrayInt);

PrintArray(arrayInt);

/*Console.Write("Введите число для добавления в массив: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] AddToArray(int[] arr, int num)
{
    int[] newArray = new int[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    newArray[newArray.Length - 1] = num;
    return newArray;
}

arrayInt = AddToArray(arrayInt, number);
PrintArray(arrayInt); */

Console.Write("Введите индекс элемента для удаления в массиве: ");
int index = Convert.ToInt32(Console.ReadLine());

int[] RemoveFromArray(int[] arr, int ind)
{
    int[] newArray = new int[arr.Length - 1];
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
arrayInt = RemoveFromArray(arrayInt, index);
PrintArray(arrayInt);