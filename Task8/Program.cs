
int[] userArray = GetArray();
PrintArray(userArray);

Console.WriteLine($"Кол-во чисел больше 0 -> {GetCountPositiveNumbers(userArray)}");


int[] GetArray ()
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите массив чисел: ");

    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());    
    }
    return array;
}

int GetCountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

void PrintArray (int[] arr)
{
    Console.WriteLine($"Введенный массив: [{String.Join("; ", arr)}]");
}

