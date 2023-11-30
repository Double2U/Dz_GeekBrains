
using Internal;

Console.WriteLine("Введите значение b1: ");

double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");

double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");

double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");

double k2 = Convert.ToInt32(Console.ReadLine());


double[] GetIntersectionPoint(double b1, double b2, double k1, double k2)
{
    double[] interPoint = new double[2];
    interPoint[0] = (b2 - b1) / (k1 - k2);
    interPoint[1] = k1 * interPoint[0] + b1;
    return interPoint;
}

void PrintPoint(double[] point)
{
    Console.WriteLine($"Точка пересечения : ({String.Join("; ", point)})");
}

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают!");
    }
    else
    {
        Console.WriteLine("Прямые параллельны!");
    }

}
else
{
    PrintPoint(GetIntersectionPoint(b1, b2, k1, k2));
}


