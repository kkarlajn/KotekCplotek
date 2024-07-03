using System;
using System.ComponentModel.Design;

namespace Kotek
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "";
            while (imie != "koniec") {
                imie = Console.ReadLine();
                if (imie == "koniec") break;
                
                Console.WriteLine("Mam na imie: " + imie);
            }

            for (int i=0; i<100; i++)
            {
                if (i > 20 && i < 60) break;
                Console.WriteLine(i);
            }
        }

    } 
}