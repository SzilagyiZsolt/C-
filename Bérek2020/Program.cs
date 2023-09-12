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
            feladatok5();
            feladatok6();
            feladatok7();
            Console.ReadKey();
        }

        private static void feladatok6()
        {                
            Console.WriteLine("6. Feladat: ");
            foreach (var item in adatok)
            {

                if (item.Részleg=="beszerzés")
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
                }
            }
            
        }

        private static void feladatok7()
        {
            Console.WriteLine("7. Feladat: Statisztika");
            foreach (var item in adatok.GroupBy(a => a.Részleg).Select(b => new { reszleg = b.Key, db = b.Count() }))
            {
            Console.WriteLine($"\t{item.reszleg} : {item.db} fő");
            }
        }

        public static string feladatok5()
        {
            Console.Write("5. Feladat: ");
            Console.WriteLine($"\tKérem egy részleg nevét: ");
            string reszleg=Console.ReadLine();
            return reszleg;
        }

        private static void feladatok3()
        {
            Console.Write("3. Feladat: ");
            Console.WriteLine($"\tDolgozók száma: {adatok.Count}");
        }
        private static void feladatok4()
        {
            double ossz=0;
            double atlag;
            Console.Write("4. Feladat: ");
            foreach (var item in adatok)
            {
                ossz+=item.Bér;
            }
            atlag= ossz/adatok.Count/1000;
            Console.WriteLine($"\tBérek átlaga: {Math.Round(atlag,1)} eFt");
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
