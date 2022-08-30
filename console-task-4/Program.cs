using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace console_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Michał", "Ana", "Felipe" };
            foreach (var name in names) // wyrzuca wszystkie imiona z listy
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");

            Console.WriteLine("============================");
            
            names.Add("Przemek");
            names.Add("Piotrek");            
            names.Remove("Ana");

            for (int i = 0; i  < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!"); // liczymy od 0 w tablicy
            }
            Console.WriteLine($"The list has {names.Count} people in it");

            Console.WriteLine("============================");

            var index = names.IndexOf("Przemek");
            Console.WriteLine($"Imię Przemek jest na {index} miejscu");

            index = names.IndexOf("Michał");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

                var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            Console.WriteLine("============================");

            names.Sort(); //sortuje od najmniejszej do największej
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine("============================");

            // list of the other types

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            //challenge - Try and write the code to generate the first 20 numbers in the sequence = answer 6765

            Console.WriteLine("=======Challenge==========");

            for (int i = 0; i < 17; i++) // 2 numbers in the list (20-2), lope start from 0 (18-1  i<17)
            {
                fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);
                Console.WriteLine(fibonacciNumbers[fibonacciNumbers.Count - 1]);
                Console.WriteLine(fibonacciNumbers.Count);
            }

            Console.WriteLine("=======Answer==========");

            Console.WriteLine($"The 20th Fibonacci number is {fibonacciNumbers[fibonacciNumbers.Count - 1]}");

            /* answer form course
            var fibonacciNumbers = new List<int> {1, 1};

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
            */
        }
    }
}