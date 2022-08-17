// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter coordinates for point A, ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates for point B, ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceIn3D(int x1_m, int y1_m, int z1_m, int x2_m, int y2_m, int z2_m)
{
    return Math.Sqrt((x2_m - x1_m) * (x2_m - x1_m) +
    (y2_m - y1_m) * (y2_m - y1_m) + (z2_m - z1_m) * (z2_m - z1_m));
}

double result = DistanceIn3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance between two points is {Math.Round(result, 2)}");