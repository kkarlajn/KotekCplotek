using System;
using System.ComponentModel.Design;

namespace Kotek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++) 
            {
                for (int j = 1; j < 11; j++) 
                {
                    if (i*j>9)
                    {
                        Console.Write(i*j+" ");
                        
                    }
                    else Console.Write(i*j+"  ");
                }
                Console.WriteLine();
            }
        }
    } 
}