
GetNumbers();

void RaisingOfPower (int A, int B)
    {
        int index = 1;
        int result = 1;
        while (index <= B)
        {
            result = A*result;
            index += 1;
        }

        Console.WriteLine ($"{A} в степени {B} -> {result}");
        
    }
void GetNumbers ()
    {
        int A;
        int B;

        Console.WriteLine ("Ввведите первое число:");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Ввведите второе число:");
        B = Convert.ToInt32(Console.ReadLine());


        RaisingOfPower(A,B);

    }






        
