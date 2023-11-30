// while (true)
// {
//     Console.WriteLine("Введите число: ");
//     string stringNumber = Console.ReadLine();
//     int number;
//     bool isNumber = int.TryParse(stringNumber, out number);
//     if (number < 0)
//     {
//        stringNumber = stringNumber.Trim('-'); 
//     }

//     if (isNumber && stringNumber.Length >= 3)
//     {
//     Console.Write($"Третья цифра числа: {number} -> {stringNumber[2]}"); 
//     break;
//     }

//     else 
//     {
//     Console.WriteLine("В этом числе третьей цифры нет или в числе присутствуют буквы! Попробуйте ввести число снова.");
//     }

// }

Console.WriteLine("Введите число:");
string stringNumber = Console.ReadLine();
int number;
int index = 0;
int thirdDigit = 0;
bool isNumber = int.TryParse(stringNumber, out number);
while (true)
{


    if (stringNumber == null)
    {
        Console.WriteLine("Введена пустая строка!");
        break;
    }

    if (number < 0)
    {
        number = number * -1;
        stringNumber = stringNumber.Trim('-');
        index = stringNumber.Length;
    }
    else
    {
        index = stringNumber.Length;
    }
    if (index < 3)
    {
        Console.WriteLine("В этом числе третьей цифры нет");
        break;
    }
    while (index >= 3)
    {
        if (isNumber)
        {
            thirdDigit = number % 10;
            index -= 1;
        }
        else
        {
            Console.WriteLine("В числе присутствуют буквы!");
            break;
        }
        if (index == 3)
        {
            Console.WriteLine($"Третья цифра числа: {number} -> {thirdDigit}");
            break;
        }
    }
    break;
}
