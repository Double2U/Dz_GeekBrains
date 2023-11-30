public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       double result = 0;
       for (int start = 1; start <= N; start++)
       {
         result = Math.Pow(start, 3);
         Console.WriteLine(result);
       }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}