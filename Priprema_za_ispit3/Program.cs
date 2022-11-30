using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_za_ispit3
{
    class Neboder
    {
        private double visina = 200;
        private int brojKatova = 100;

        public double Visina { get => visina; set => visina = value; } 
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public override string ToString()
        {
            return "Broj katova je: " + this.BrojKatova + "Visina je: " + this.Visina;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder();  

            Console.WriteLine(Tower.ToString());    

            Console.ReadKey();
        }
    }
}
