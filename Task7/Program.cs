Console.WriteLine("Введите минимальное значение в массиве:");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве:");
int maxNumber = Convert.ToInt32(Console.ReadLine());
int [] result = GetRandomArray(8, minNumber, maxNumber);
Console.Write($"[{String.Join(";", result)}]");

int [] GetRandomArray(int size, int minNumber, int maxNumber)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(minNumber,maxNumber + 1);
    }
    return array;
    
}