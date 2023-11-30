
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int functionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return functionAkkerman(m - 1, 1);
    }
    else
    {
        return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
    }
}

Console.WriteLine(functionAkkerman(m, n));