double distanceCalc(int xa, int ya, int za, int xb, int yb, int zb)
{
    double ab = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return ab;
}
Console.Write("Введите xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ya: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите za: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите xb: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yb: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());

double res = Math.Round(distanceCalc(n1, n2, n3, n4, n5, n6), 2);

Console.WriteLine($"Расстояние между точками A({n1},{n2},{n3}) и B({n4},{n5},{n6}) -> {res}");