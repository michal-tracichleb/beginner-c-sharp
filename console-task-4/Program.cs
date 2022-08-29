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

            names.Add("Piotrek");
            names.Add("Przemek");
            names.Remove("Ana");

            for (int i = 0; i  < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!"); // liczymy od 0 w tablicy
            }
            Console.WriteLine($"The list has {names.Count} people in it");
        }
    }
}