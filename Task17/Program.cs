// 17.

// Console.WriteLine("Введите координаты точки Х и У");
// Console.Write("X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.
// if (X > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (X < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (X < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (X > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else Console.WriteLine("Введены неверные коордитнаты");

string Quard(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены неверные коордитнаты";
}
string result = Quard(x,y);
Console.WriteLine(result);