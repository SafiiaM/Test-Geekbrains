// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// void GetQuad(int a)
// {
//     int index = 1;
//     while (index <= a)
//     {

//         int quad = index * index;
//         Console.Write($"{quad} ");
//         index++;
//     }
// }
// GetQuad(a);


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)

{
    Console.WriteLine($"Квадрат числа {i} | {i * i, 2}  | ");
}


