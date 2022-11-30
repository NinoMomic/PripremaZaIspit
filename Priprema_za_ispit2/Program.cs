using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_za_ispit2
{
    class KlasaX
    {
        int broj = 10;
        public int Broj { get => broj; set => broj = value; }

        public override string ToString()
        {
            return "Vrijednost varijable je: "+this.broj;
            
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            KlasaX Broj = new KlasaX(); 

            Console.WriteLine(Broj.ToString());

            Console.ReadKey();
        }
    }
}
