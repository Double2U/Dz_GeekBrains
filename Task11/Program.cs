

Console.WriteLine("Введите начало промежутка чисел M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец промежутка чисел N: ");
int N = int.Parse(Console.ReadLine());

if (M > N)
{
     return;
}


int SumNumbers(int start, int end)
{
    if(start == end)
    {
        return start;
    }

    return start + SumNumbers(start + 1, end);

}

Console.WriteLine(SumNumbers(M,N));