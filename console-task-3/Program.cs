// branches-and-loops

using System;

namespace ConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            //if statement

            int a = 5;
            int b = 3;
            int c = 4;
            // || - or   && - or   == - equal
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            Console.WriteLine("==============================================================");

            // loop -> while; do while; for

            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Hello World! The counter is {counter} (while)");
                counter++;
            }

            Console.WriteLine("==============================================================");

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter} (do -> while)");
                counter++;
            } while (counter < 5);

            Console.WriteLine("==============================================================");

            for (counter = 0; counter < 5; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter} (for)");
            }

            Console.WriteLine("==============================================================");

            for (int row = 1; row < 5; row++)
            {
                for (char column = 'a'; column < 'e'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column}) (for in for)");
                }
            }

            //Combine branches and loops
            Console.WriteLine("==============================================================");
           
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}