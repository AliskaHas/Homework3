// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты первой точки через пробел: ");
int[] firstPoint = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите координаты второй точки через пробел: ");
int[] secondPoint = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int point1 = (int)Math.Pow(firstPoint[0]-secondPoint[0], 2);
int point2 = (int)Math.Pow(firstPoint[1]-secondPoint[1], 2);
int point3 = (int)Math.Pow(firstPoint[2]-secondPoint[2], 2);

System.Console.WriteLine($"{Math.Round(Math.Sqrt(point1+point2+point3),3)}");