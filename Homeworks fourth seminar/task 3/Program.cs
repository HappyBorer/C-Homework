/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int size = 8;
int[] figure = new int[size];
for (int i = 0; i < figure.Length; i++)
{
    figure[i] = new Random().Next(1, 101);
}
PrintArray(figure);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.WriteLine($"{arr[i]}.");
        }
    }
}