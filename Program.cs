// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координату x точки А ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату x1 точки B");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y точки А ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y1 точки B");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату z точки А ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату z1 точки B");
int z1 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((Math.Pow(x1-x, 2))+(Math.Pow(y1-y, 2))+(Math.Pow(z1-z, 2)))*1;
Console.WriteLine(Math.Round(result, 2));

