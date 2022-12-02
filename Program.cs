using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        bool bFortsätt = true;

        while (bFortsätt)
        {
            Console.WriteLine("Skriv ett nummer: ");
            string numInput = Console.ReadLine();
            
            int num = 0;
            bool success = Int32.TryParse(numInput, out num);

            if (success)
            {
                bFortsätt = false;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Felaktigt värde");
            }
        }
        Console.WriteLine("Klicka för att avsluta");

        Console.ReadLine();
    }
}