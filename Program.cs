using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int resultat;
        if (!int.TryParse(Console.ReadLine(), out resultat))
            Console.WriteLine("Skriv in en siffra");
    }
    public static bool TryParse(string s, out int result)
    {
        return int.TryParse(s, out result);
    }
    
}