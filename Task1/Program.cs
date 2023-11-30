while (true)
{
    Console.WriteLine("Введите трёхзначное число: ");
    string stringNumber = Console.ReadLine();
    int number;
    bool isNumber = int.TryParse(stringNumber, out number);

    if (stringNumber == null)
    {
        Console.WriteLine("Введена пустая строка!");
        break;
    }

    if (isNumber && stringNumber.Length == 3)
    {
        int secondDigit = (number / 10) % 10;
        Console.Write($"Вторая цифра числа: {number} -> {secondDigit}");
        break;
    }

    else
    {
        Console.WriteLine("В числе присутствуют буквы или число не трёхзначное, попробуйте ввести число снова!");
    }

}
