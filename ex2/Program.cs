Console.Clear();

Console.WriteLine("coordinates of the first point: ");
Console.Write("x = ");
int ax = int.Parse(Console.ReadLine());

Console.Write("y = ");
int ay = int.Parse(Console.ReadLine());

Console.Write("z = ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("coordinates of the second point: ");
Console.Write("x = ");
int bx = int.Parse(Console.ReadLine());

Console.Write("y = ");
int by = int.Parse(Console.ReadLine());

Console.Write("z = ");
int bz = int.Parse(Console.ReadLine());

Console.WriteLine($"Distance = {Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)+ Math.Pow(az + bz, 2)):f2}");