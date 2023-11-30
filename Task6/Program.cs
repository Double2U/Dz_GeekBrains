string GetNumber ()
{
    string stringNumber = string.Empty;
    Console.WriteLine("Введите число: ");
    stringNumber = (Console.ReadLine());
    return stringNumber;
}

int sizeNumber(string stringNumber)
{
    int sizeNumber = stringNumber.Length;
    return sizeNumber;
}

int isNumber (string stringNumber)
{
    int number;
    bool isNumber = int.TryParse(stringNumber, out number);
    while (isNumber == false)
    {
        Console.WriteLine("Неверные данные! Введите число заново.");
        isNumber = int.TryParse(stringNumber, out number);
    }
    return number;
}

int[] GetDigits (int size, int number)
{

    int[] numberDigits = new int[size];
    int i = 0;

        while (number > 0)
        {
            numberDigits[i] = number %  10; 
            number = number / 10;
            i++;
        }
    return numberDigits;
}

void SumDigits (int[] numberDigits)
{
    int sum = 0;
    for (int i = 0; i < numberDigits.Length; i++)
    {
        sum = sum + numberDigits[i];
    }
    Console.WriteLine($"{sum}");
}
string stringNumber = GetNumber();
int verifiedNumber = isNumber(stringNumber);
int size = sizeNumber(stringNumber);
int [] arrayDigits = GetDigits(size, verifiedNumber);
SumDigits(arrayDigits);