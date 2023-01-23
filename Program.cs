Console.Clear();
double Sxyz(double xFirst,double yFirst, double zFirst, double xSecond, double ySecond, double zSecond)
{
    double distance = Math.Sqrt(Math.Pow(xFirst - xSecond,2) + Math.Pow(yFirst - ySecond,2) + Math.Pow(zFirst - zSecond,2));
    return distance;
}
Console.WriteLine("Введите координаты xFirst : ");
double xFirst = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты xSecond : ");
double xSecond = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты yFirst : ");
double yFirst = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты ySecond : ");
double ySecond = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты zFirst : ");
double zFirst = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты zSecond : ");
double zSecond = double.Parse(Console.ReadLine()!);
Sxyz(xFirst, xSecond, yFirst, ySecond, zFirst, zSecond);
double d = Sxyz(xFirst, xSecond, yFirst, ySecond, zFirst, zSecond);
Console.WriteLine();
Console.WriteLine($"{d:f2}");