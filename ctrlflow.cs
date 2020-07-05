using System;

namespace CtrlFlow
{
    static public class Ctrl
    {
        static public void Flow()
        {
            Console.WriteLine("Welcome to Ctrl Flow World!");
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }


            Console.WriteLine("While Loops");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            counter = 0;
            Console.WriteLine("Do While Loops");
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            Console.WriteLine("For Loops");
            counter = 0;
            for (; counter < 10; counter=counter+2)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }

            Console.WriteLine("Nested For Loops");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}