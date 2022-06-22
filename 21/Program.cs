// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Коортиданты точки А");
Console.Write("Введите координату по Х для точки А: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по У для точки A: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Z для точки A: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Коортиданты точки B");
Console.Write("Введите координату по Х для точки B: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по У для точки B: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Z для точки B: ");
double z2 = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве равно {distance}");