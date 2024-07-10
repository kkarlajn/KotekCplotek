using System;
using System.ComponentModel.Design;

namespace Kotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitty Kikki = new Kitty("Kikki");
            Kikki.meow();
            Kitty Mimmi = new Kitty("Mimmi");
            Mimmi.meow();
            Kitty Diddi = new Kitty("Diddi");
            Diddi.meow();
            Kitty Lilli = new Kitty("Lilli");
            Lilli.meow();
            Kitty Sissi = new Kitty("Sissi");
            Sissi.meow();
            Kitty Fiffi = new Kitty("Fiffi");
            Fiffi.meow();
        }

    } 
}