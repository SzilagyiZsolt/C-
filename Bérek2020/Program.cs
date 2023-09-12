using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérek2020
{
    internal class Program
    {
        static List<Bérek> adatok = new List<Bérek>();
        static void Main(string[] args)
        {
            adatokbeolvasása();
            feladatok3();
            feladatok4();
            Console.ReadKey();
        }
        private static void feladatok3()
        {
            Console.Write("3. Feladat: ");
            Console.WriteLine($"\tDolgozók száma: {adatok.Count}");
        }
        private static void feladatok4()
        {
            int ossz=0;
            int atlag;
            Console.Write("4. Feladat: ");
            foreach (var item in adatok)
            {
                ossz+=item.Bér;
            }
            atlag= ossz/adatok.Count;
            Console.WriteLine($"\tBérek átlaga: {atlag}");
        }
        private static void adatokbeolvasása()
        {
            try
            {
                using (StreamReader file = new StreamReader("berek2020.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Bérek(file.ReadLine()));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
