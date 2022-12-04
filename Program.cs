using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett heltal");
        Console.WriteLine(ToaParse());
    }

    public static bool ToaParse()
    {
        string Wallah = Console.ReadLine();
        try
        {
            int num = Int32.Parse(Wallah);
            return true;
        }
        catch
        {
            return false;
        }
    }
}