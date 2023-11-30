Console.WriteLine ("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1: Console.Write("Понедельник - не выходной"); break;
    case 2: Console.Write("Вторник - не выходной"); break;
    case 3: Console.Write("Среда - не выходной"); break;
    case 4: Console.Write("Четверг - не выходной"); break;
    case 5: Console.Write("Пятница - не выходной"); break;
    case 6: Console.Write("Суббота - выходной"); break;
    case 7: Console.Write("Воскресенье - выходной"); break;
    
    default: Console.WriteLine("Введена неправильная цифра!"); break;
}
