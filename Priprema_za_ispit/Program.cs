using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_za_ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Upiši 3 broja: ");

            Console.WriteLine("1. broj je: ");
            x = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("2. broj je: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. broj je: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x <= 0 || y <= 0 || z<=0)

                Console.WriteLine("Brojevi koje ste unjeli nisu " +
                    "stranice pravokutnog trokuta");

            Console.ReadKey();
        }
    }
}
