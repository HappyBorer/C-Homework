/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

using static System.Console;
Clear();
int Input(string figure)
{
    Write(figure);
    return Convert.ToInt32(ReadLine());
}

int x1 = Input("Введите координату x1: ");
int y1 = Input("Введите координату y1: ");
int z1 = Input("Введите координату z1: ");
int x2 = Input("Введите координату x2: ");
int y2 = Input("Введите координату y2: ");
int z2 = Input("Введите координату z2: ");

int DifferenceCoord(int a1, int a2)
{
    return a1 - a2;
}

int Square(int num)
{
    return num * num;
}
double segmentLength = Math.Sqrt(Square(DifferenceCoord(x1, x2)) + Square(DifferenceCoord(y1, y2)) + Square(DifferenceCoord(z1, z2)));

WriteLine(segmentLength);