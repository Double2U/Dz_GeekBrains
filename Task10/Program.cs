Console.WriteLine("Введите начало промежутка чисел M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец промежутка чисел N: ");
int N = int.Parse(Console.ReadLine());


string PrintNumbers(int start, int end)
{

    if (start == end)
    {
        return start.ToString();
    }
    
     return (start + "\t" + PrintNumbers(start + 1, end));

}

if (M > N)
{
     return;
}
Console.WriteLine(PrintNumbers(M,N));