using System;

namespace Kotek;

public class Kitty
{
    string name;

    public Kitty(string newName)
    {
        name = newName;
    }

    public void meow()
    {
        Console.WriteLine(name + ": Hello");
    }
    public static void help()
    {
        Console.WriteLine("it's a Kitty class");
    }

}
