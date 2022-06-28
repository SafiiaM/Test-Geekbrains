// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

Console.WriteLine("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Double Pifagor(int a1, int b1, int a2, int b2)
{
    Double Distance = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2));
    Distance = Math.Round(Distance,2);
    return Distance;

}
Double result = Pifagor(x1,y1,x2, y2);
Console.WriteLine(result);