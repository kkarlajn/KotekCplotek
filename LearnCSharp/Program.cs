using System;
using System.ComponentModel.Design;

namespace Kotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oceny = { 3, 4, 5, 2, 1 };
            foreach(int ocena in oceny)
            {
                Console.WriteLine(ocena);
            }
            Console.WriteLine("Najwyzsza ocena to " + oceny.Max());
            Console.WriteLine("Najnizsza ocena to " + oceny.Min());
            Console.WriteLine("Suma ocen " + oceny.Sum());
        }

    } 
}