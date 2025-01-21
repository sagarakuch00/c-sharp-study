using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Sagar");

        printA();
        printB("Sagar");
        printC("Sagar", "Akuch");
        string result = printD();
        Console.WriteLine(result);

        result = printE("Sagar");
        Console.WriteLine(result);

        Console.ReadKey();
    }

    static void printA()
    {
        Console.WriteLine("printA method called");


    }

    static void printB(string name)
    {
        Console.WriteLine($"Hello : {name}");

    }

    static void printC(string fn, string ln)
    {
        Console.WriteLine($"Fullnam = {fn} {ln}");
    }

    static string printD()
    {
        return "printD: Welcome Sir !!!";
    }

    static string printE(string name)
    {
        return $"Print E : Good Morning {name} !!!";
    }
}


    