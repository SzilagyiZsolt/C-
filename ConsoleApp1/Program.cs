using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //két szám bekérése és összeadása
            int elso, masodik; //deklarálás
            Console.WriteLine("Két szám összeadása");
            elso=szamotKer("Adj meg egy számot: ");
            masodik=szamotKer("Adj meg egy másik számot: ");
            Console.WriteLine("A két szám összege: " +(elso+masodik).ToString());
            Console.ReadKey();
        }
        private static int szamotKer(string szo)
        {
            int bekertSzam;
            Console.Write(szo);
            bekertSzam=int.Parse(Console.ReadLine());
            return bekertSzam;
        }
    }
}
