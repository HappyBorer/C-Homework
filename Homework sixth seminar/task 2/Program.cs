/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/


using static System.Console;
Clear();

double InputDouble(string output)
{
    Write(output);
    return Convert.ToDouble(ReadLine());
}

double b1 = InputDouble("Введите b1: ");
double k1 = InputDouble("Введите k1: ");
double b2 = InputDouble("Введите b2: ");
double k2 = InputDouble("Введите k2: ");

if (k1 == k2)
{
    WriteLine("Прямые паралельны или совпадают");
    return;
}
double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;
WriteLine($"Координаты точки пересечения двух прямых ({x};{y})");





