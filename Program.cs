using System;
class Program
{
    static void Main()
    {
        String a = "FOR";
        String b = "THE";
        object c = "HORDE";
        string Horde = string.Format("In WOW you are {0} {1} {2}!!!", a, b, c);

        Console.WriteLine(Horde);

        c = 5;
        Horde = string.Format("In WOW you are {0} {1} {2}!!!", a, b, c);

        Console.WriteLine(Horde);

    }
}
